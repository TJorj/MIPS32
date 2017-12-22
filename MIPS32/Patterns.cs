using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public static class Patterns
    {
        public const string instruction_name = @"(?<nume_instr>\w+)\s*";
        public const string nonalphanumerical = @"[^a-zA-Z\d\s*]";
        public const string alpha = @"[a-zA-Z]";
        public const string numerical = @"[0-9]";
        public const string register_name = @"(?<nume_reg>\s*[$]\s*[a-zA-Z]\s*[0-9]\s*)";
        public const string paranthesis_open = @"\s*[(]\s*";
        public const string paranthesis_close = @"\s*[)]\s*";
    }
}
