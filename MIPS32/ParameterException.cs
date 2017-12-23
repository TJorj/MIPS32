using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
