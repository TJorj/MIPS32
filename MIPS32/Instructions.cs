using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public static class Instructions
    {

        public static Dictionary<string, InstructionType> Collections = new Dictionary<string, InstructionType>();
        public static void LoadInstructins()
        {
            System.IO.StreamReader inFile = new System.IO.StreamReader(@"instructions.txt");
            while (!inFile.EndOfStream)
            {
                string line = inFile.ReadLine();
                string[] line_el = line.Split(' ');
                Collections.Add(line_el[0], new InstructionType(line_el[1], line_el[2], line_el[3]));
            }
            inFile.Close();
        }
        
    }
}
