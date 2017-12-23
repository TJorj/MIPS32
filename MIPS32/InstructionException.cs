using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public class InstructionException : Exception
    {
        public InstructionException()
        {

        }
        public InstructionException(string message) : base(message)
        {

        }
        public InstructionException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
