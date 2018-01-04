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
        public string pc;   
        public string rs_name, rt_name, rd_name, shamt, operation, immediate, rs_value, rt_value, rd_value;
        public SimulatorParameters(string _rs, string _rt, string _rd, string _shamt, string _immediate, string _operation)
        {
            rs_name = _rs.Trim('$');
            rd_name = _rd.Trim('$');
            rt_name = _rt.Trim('$');
            shamt = _shamt;
            operation = _operation;
            immediate = _immediate;
            pc = Counter.increment().ToString();
        }
    }
}
