using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public class InstructionType
    {
        public string Opcode { get; }
        public string Funct { get; }
        public string Type { get; }
        public InstructionType(string _type, string _opcode, string _funct)
        {
            Opcode = ConvertHexToBinary_6(_opcode);
            Type = _type;

            //verifica daca instructiunea are cod Funct
            if (String.Equals(_funct, "null"))
                Funct = null;
            else
                Funct = ConvertHexToBinary_6(_funct);
        }

        //metoda ce converteste o valoare hexa intr-o valoarea binara pe 6 biti incluzand zerouri
        private string ConvertHexToBinary_6(string hex_string)
        {
             hex_string = Convert.ToString(Convert.ToInt32(hex_string, 16),2);
            if (hex_string.Count() < 6)
                hex_string = hex_string.PadLeft(6, '0');
            return hex_string;
        }
    }
}
