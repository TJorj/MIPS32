using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        private static string immediate_offset;
        private static string jmp_adr;

        private static Regex rgx;

        //variabile constante pentru valori implicite
        private const string shamt_generic = "00000";
        private const string reg_dest_generic = "noregister";
        private const string reg_src_generic = "noregister";
        private const string reg_tmp_generic = "noregister";
        private const string immediate_generic = "";
        
        

        public static string LineParse(string text)
        {
            
            rgx = new Regex(Patterns.instruction_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            //exceptie daca nu s-a gasit instructiune sau 
            //daca s-au gasit instructiuni (string de 2-5 litere fara spatii) in plus
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
            if(Instructions.Collections[nume_instr].Type == "I")
            {
                switch(nume_instr)
                {
                    case "lb":
                    case "lbu":
                    case "lh":
                    case "lhu":
                    case "lui":
                    case "lw":
                    case "sb":
                    case "sh":
                    case "sw":
                    case "lwc1":
                    case "ldc1":
                    case "swc1":
                    case "sdc1":
                        {
                            ITypeOffsetParser(text);
                            break;
                        }
                    default:
                        {
                            ITypeGenericParser(text);
                            break;
                        }
                }
            }
            if(Instructions.Collections[nume_instr].Type == "J")
            {
                JTypeGenericParser(text);
            }
            return parsed_string;
        }
        private static void RTypeMFCParser(string _text)
        {
            //instructiunea mfc0
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 2)
            {
                reg_tmp = matches[0].Value.Replace(" ", "");
                reg_dest = matches[1].Value.Replace(" ", "");
                RTypeStringGenerator(reg_src_generic, reg_tmp, reg_dest, shamt_generic);
            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void RTypeMFParser(string _text)
        {
            //instructiunile MFLO MFHI
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
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
                if(matches.Count==0 || matches.Count > 1)
                {
                    throw new ParameterException("Parameter error for shift value");
                }
                else
                {
                    //completeaza valoarea cu 0 sau exceptie daca depaseste marimea 
                    shamt = HexToBinary(matches[0].Value.Replace(" ", ""));
                    if (shamt.Count() < 5)
                        shamt = shamt.PadLeft(5, '0');
                    else
                        throw new ParameterException("Parameter error for shift value ");
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
                SimulatorDisplayQueue.InstructionsDispaly.Enqueue(_text);
          
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
            SimulatorList.ListToExecute.Add(new SimulatorParameters(_reg_src,_reg_tmp,_reg_dest, _shamt,immediate_generic, nume_instr));
        }
        private static void ITypeGenericParser(string _text)
        {
            //instructiunile de tip nume_ins reg reg immediate_val
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 2)
            {
                reg_tmp = matches[0].Value.Replace(" ", "");
                reg_src = matches[1].Value.Replace(" ", "");
                rgx = new Regex(Patterns.immediate, RegexOptions.IgnoreCase);
                matches = rgx.Matches(_text);
                if (matches.Count == 0 || matches.Count > 1)
                {
                    throw new ParameterException("Parameter error for immediate value");
                }
                else
                {
                    //completeaza valoarea cu 0 sau exceptie daca depaseste marimea 
                    immediate_offset = HexToBinary(matches[0].Value.Replace(" ", ""));
                    if(immediate_offset.Count() < 16)
                        immediate_offset = immediate_offset.PadLeft(16, '0');
                    else
                        throw new ParameterException("Paramaeter error for immediate value");
                    ITypeStringGenerator(reg_src, reg_tmp, immediate_offset);
                }
            }
            else
                throw new ParameterException("Parameter count error");

        }
        private static void ITypeOffsetParser(string _text)
        {
            //instructiunile de tip nume_instr reg offset(reg)
            rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if (matches.Count == 2)
            {
                reg_src = matches[0].Value.Replace(" ", "");
                reg_tmp = matches[1].Value.Replace(" ", "");
                rgx = new Regex(Patterns.offset, RegexOptions.IgnoreCase);
                matches = rgx.Matches(_text);
                if (matches.Count == 0 || matches.Count > 1)
                {
                    throw new ParameterException("Parameter error for offset value");
                }
                else
                {
                    //completeaza valoarea cu 0 sau exceptie daca depaseste marimea 
                    immediate_offset = HexToBinary(matches[0].Groups["offset_val"].Value.Replace(" ", ""));
                    if (immediate_offset.Count() < 16)
                        immediate_offset = immediate_offset.PadLeft(16, '0');
                    else
                        throw new ParameterException("Paramaeter error for offset value");
                    ITypeStringGenerator(reg_src, reg_tmp, immediate_offset);
                }

            }
            else
                throw new ParameterException("Parameter count error");
        }
        private static void ITypeStringGenerator(string _reg_src, string _reg_tmp, string _immediate_offset)
        {
            //generaza stringul complet
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
            parsed_string += _immediate_offset;
        }
        private static void JTypeGenericParser(string _text)
        {
            //genereza stringul pentru instructiuni J
            rgx = new Regex(Patterns.jump_address, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(_text);
            if(matches.Count == 0 || matches.Count > 1)
            {
                throw new ParameterException("Parameter error for jump adress");
            }
            else
            {
                //completeaza valoarea cu 0 sau exceptie daca depaseste marimea 
                jmp_adr = HexToBinary(matches[0].Value.Replace(" ", ""));
                if (jmp_adr.Count() < 26)
                {
                    SimulatorList.ListToExecute.Add(new SimulatorParameters("", "", "", "", jmp_adr, nume_instr));
                    jmp_adr = jmp_adr.PadLeft(26, '0');
                }
                else
                    throw new ParameterException("Parameter error for jump adress");
                parsed_string += jmp_adr ;
                SimulatorDisplayQueue.InstructionsDispaly.Enqueue(_text);
               
            }
        }
        private static string HexToBinary(string hex_string)
        {
            //converteste din hex in binar
            string binary_string;
            binary_string = Convert.ToString(Convert.ToInt64(hex_string, 16), 2);
            return binary_string;
        }
    }
}
