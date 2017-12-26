using System;

namespace MIPS32
{
    class ParameterException : Exception
    {
        public ParameterException()
        {

        }
        public ParameterException(string message) : base(message)
        {

        }
        public ParameterException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
