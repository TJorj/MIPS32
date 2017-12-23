using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MIPS32
{
    public static class TextParser
    {
        //variabile ce vor fi prelucrate
        private static string parsed_string = null;
        private static string nume_instr = null;
        private static string reg_dest;
        private static string reg_src;
        private static string reg_tmp;
        private static string shamt;

        private static Regex rgx;

        //variabile constante pentru valori implicite
        private const string shamt_generic = "00000";
        private const string reg_dest_generic = "noregister";
        private const string reg_src_generic = "noregister";
        private const string reg_tmp_generic = "noregister";

      
        public static string LineParse(string text)
        {
            
            rgx = new Regex(Patterns.instruction_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            //exceptie daca nu s-a gasit instructiune sau 
            //daca s-au gasit instructiuni (string de 3-5 litere fara spatii) in plus
            //stringuri de 6+ litere sunt ignorate 
            if (matches.Count == 0 || matches.Count > 1)
            {
                throw new InstructionException("Instruction error ");
            }
            nume_instr = matches[0].Value.Replace(" ", "");

            //exceptie in caz de instructiune inexistenta
            try
            {
                parsed_string = Instructions.Collections[nume_instr].Opcode + " ";
            }
            catch(Exception)
            {
                throw new InstructionException("Instruction error for " + nume_instr);
            }
            //prelucrare instructiuni de tip R
            if(Instructions.Collections[nume_instr].Type == "R")
            {
                
                //prelucrare instructiuni particulare
                switch(nume_instr)
                {
                    case "jr":
                        {
                            RTypeJumpParser(text);
                            break;
                        }
                    case "jalr":
                        {
                            RTypeJumpAndLinkParser(text);
                            break;
                        }
                    case "sll":
                    case "srl":
                    case "sra":
                        {
                            RTypeImmediateShiftParser(text);
                            break;
                        }
                    case "div":
                    case "divu":
                    case "mult":
                    case "multu":
                        {
                            RTypeMultDivParser(text);
                            break;
                        }
                    case "mfhi":
                    case "mflo":
                        {
                            RTypeMFParser(text);
                            break;
                        }
                    case "mfc0":
                        {
                            RTypeMFCParser(text);
                            break;
                        }                 
                    default:
                        {
                            RTypeGenericParser(text);
                            break;
                        }
                }
            }
            return parsed_string;
        }
        private static void RTypeMFCParser(string text)
        {
            //instructiunea mfc0
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            if (matches.Count == 2)
            {
                reg_tmp = matches[0].Value.Replace(" ", "");
                reg_dest = matches[1].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src_generic, reg_tmp, reg_dest, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeMFParser(string text)
        {
            //instructiunile MFLO MFHI
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            if (matches.Count == 1)
            {
                reg_dest = matches[0].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src_generic, reg_tmp_generic, reg_dest, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeJumpAndLinkParser(string _text)
        {
            //instr JALR
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 2)
            {
                reg_dest = matches[0].Value.Replace(" ", "");
                reg_src = matches[1].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src, reg_tmp_generic, reg_dest, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeJumpParser(string _text)
        {
            //instructiunea JR
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 1)
            {
                reg_src = matches[0].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src, reg_tmp_generic, reg_dest_generic, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeImmediateShiftParser(string _text)
        {
            //instructiunile de shift cu valorea imediata
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 2)
            {
                reg_dest = matches[0].Value.Replace(" ", "");
                reg_tmp = matches[1].Value.Replace(" ", "");
                rgx = new Regex(Patterns.shamt, RegexOptions.IgnoreCase);
                matches = rgx.Matches(_text);
                if(matches.Count==0)
                {
                    throw new ParameterException("Parameter error for immediate value");
                }
                else
                {
                    shamt = matches[0].Value.Replace(" ", "");
                    RTypeStringGenerator(reg_src_generic, reg_tmp, reg_dest, shamt);
                }
            }
            else
                throw new ParameterException("Parameter count error");
            }
        private static void RTypeGenericParser(string _text)
        {
            //functie ce parseaza instructiunile R generice cu cate 3 registri
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 3)
            {
                reg_dest = matches[0].Value.Replace(" ", "");
                reg_src = matches[1].Value.Replace(" ", "");
                reg_tmp = matches[2].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src, reg_tmp, reg_dest, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeMultDivParser(string _text)
        {
            //instructiunile MUL MULU DIV DIVU
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if(matches.Count == 2)
            {
                reg_src = matches[0].Value.Replace(" ", "");
                reg_tmp = matches[1].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src, reg_tmp, reg_dest_generic, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeStringGenerator(string _reg_src, string _reg_tmp, string _reg_dest, string _shamt)
        {
            //generaza stringul complet
            //pentru instructiunile care au un parametru lipsa se trimite ca parametru valoarea generica (implicita)
            try
            {
                parsed_string += Registers.Collections[_reg_src].Number + " ";
            }
            catch (Exception)
            {
                throw new ParameterException("Parameter error for " + _reg_src);
            }
            try
            {
                parsed_string += Registers.Collections[_reg_tmp].Number + " ";
            }
            catch (Exception)
            {
                throw new ParameterException("Parameter error for " + _reg_tmp);
            }
            try
            {
                parsed_string += Registers.Collections[_reg_dest].Number + " ";
            }
            catch (Exception)
            {
                throw new ParameterException("Parameter error for " + _reg_dest);
            }
            parsed_string += _shamt + " " + Instructions.Collections[nume_instr].Funct;
        }
    }
}
