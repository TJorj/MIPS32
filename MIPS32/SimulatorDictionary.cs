using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS32
{
    public delegate void execute(SimulatorParameters Sim);
    public static class SimulatorInstructions
    {
        public static Dictionary<string, execute> Dict = new Dictionary<string, execute>();

        public static void LoadSimulator()
        {
            Dict.Add("add", add);
            Dict.Add("j", jump);
            Dict.Add("sub", sub);
        }


        private static void add(SimulatorParameters Sim)
        {
            int _rs = Convert.ToInt32(Sim.rs_value);
            int _rt = Convert.ToInt32(Sim.rt_value);

            Sim.rd_value = Convert.ToString( _rs + _rt);
            Sim.immediate = "";

        }
        private static void jump(SimulatorParameters Sim)
        {
            Sim.immediate = Convert.ToInt32(Sim.immediate,2).ToString();
        }
        private static void sub(SimulatorParameters Sim)
        {
            int _rs = Convert.ToInt32(Sim.rs_value);
            int _rt = Convert.ToInt32(Sim.rt_value);

            Sim.rd_value = Convert.ToString(_rs - _rt);
            Sim.immediate = "";

        }
    }
}
