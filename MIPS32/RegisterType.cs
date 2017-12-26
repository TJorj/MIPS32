using System;
using System.Linq;

namespace MIPS32
{
    public class RegisterType
    {
        public string Number { get; }

        public RegisterType (string _number)
        {
            Number = ConvertDecToBinary_5(_number);
        }
        
        //converteste un numar decimal intr-un numar binar pe 5 biti incluzand 0
        private string ConvertDecToBinary_5(string dec_string)
        {
             dec_string = Convert.ToString(Convert.ToInt32(dec_string), 2);
            if (dec_string.Count() < 5)
                dec_string = dec_string.PadLeft(5, '0');
            return dec_string;
        }

    }
}
