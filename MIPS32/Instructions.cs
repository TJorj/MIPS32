using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MIPS32
{
    public static class Instructions
    {

        public static Dictionary<string, InstructionType> Collections = new Dictionary<string, InstructionType>();
        public static void LoadInstructions()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("MIPS32.instructions.txt")) 
            using (StreamReader inFile = new StreamReader(stream))
            {
                while (!inFile.EndOfStream)
                {
                    string line = inFile.ReadLine();
                    string[] line_el = line.Split(' ');
                    Collections.Add(line_el[0], new InstructionType(line_el[1], line_el[2], line_el[3]));
                }
            }
        }
        
    }
}
