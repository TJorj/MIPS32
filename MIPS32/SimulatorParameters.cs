using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{

    public class SimulatorParameters
    {
        private static class Counter
        {
            private static int pc = -4;
            public static int increment()
            {
                pc = pc + 4;
                return pc;
            }
        }
        public int pc;   
        public string rs, rt, rd, shamt, operation, immediate;
        public SimulatorParameters(string _rs, string _rt, string _rd, string _shamt, string _immediate, string _operation)
        {
            rs = _rs;
            rd = _rd;
            rt = _rt;
            shamt = _shamt;
            operation = _operation;
            immediate = _immediate;
            pc = Counter.increment();
        }
    }
}
