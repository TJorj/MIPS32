using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    class Registers
    {
        public static Dictionary<string, RegisterType> Collections = new Dictionary<string, RegisterType>();
        public static void LoadRegisters()
        {
            System.IO.StreamReader inFile = new System.IO.StreamReader(@"registers.txt");
            while (!inFile.EndOfStream)
            {
                string line = inFile.ReadLine();
                string[] line_el = line.Split(' ');
                Collections.Add(line_el[0], new RegisterType(line_el[1]));
            }
            inFile.Close();
        }
    }
}
