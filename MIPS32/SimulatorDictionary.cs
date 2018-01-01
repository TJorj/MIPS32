using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public delegate void execute(string rs, string rt, out string rd, string shamt, string immediate, out string pc);
    public static class SimulatorInstructions
    {
        public static Dictionary<string, execute> Dict = new Dictionary<string, execute>();

        public static void LoadSimulator()
        {
            Dict.Add("add", add);
            Dict.Add("j", jump);
            Dict.Add("sub", sub);
        }


        private static void add(string rs, string rt, out string rd, string shamt, string immediate, out string pc)
        {
            int _rs = Convert.ToInt32(rs);
            int _rt = Convert.ToInt32(rt);

            rd = Convert.ToString(_rs + _rt);
            pc = "";

        }
        private static void jump(string rs, string rt, out string rd, string shamt, string immediate, out string pc)
        {
            rd = "";


            pc = Convert.ToInt32(immediate,2).ToString();
        }
        private static void sub(string rs, string rt, out string rd, string shamt, string immediate, out string pc)
        {
            int _rs = Convert.ToInt32(rs);
            int _rt = Convert.ToInt32(rt);

            rd = Convert.ToString(_rs - _rt);
            pc = "";

        }
    }
}
