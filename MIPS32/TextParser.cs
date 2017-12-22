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
        private static Regex rgx;
        private static string shamt = "00000";
        public static string LineParse(string text)
        {
            string parsed_string = null;
            rgx = new Regex(Patterns.instruction_name, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            GroupCollection groups = matches[0].Groups;
            //CaptureCollection captures = groups["nume_reg"].Captures;
            string nume_instr = groups["nume_instr"].Value.Replace(" ", "");
            parsed_string = Instructions.Collections[nume_instr].Opcode + " ";
            if(Instructions.Collections[nume_instr].Type == "R")
            {
                rgx = new Regex(Patterns.register_name, RegexOptions.IgnoreCase);
                matches = rgx.Matches(text);
                string reg_dest = matches[0].Value.Replace(" ", "");
                string reg_src = matches[1].Value.Replace(" ", "");
                string reg_tmp = matches[2].Value.Replace(" ", "");
                parsed_string += Registers.Collections[reg_src].Number + " " + Registers.Collections[reg_tmp].Number + " " + Registers.Collections[reg_dest].Number+ " ";
                parsed_string += shamt + " ";
                parsed_string += Instructions.Collections[nume_instr].Funct;

            }
            
 



            return parsed_string;
        }
    }
}
