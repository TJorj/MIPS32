using System;

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
