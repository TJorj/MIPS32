using System;
using System.Collections.Generic;

namespace MIPS32
{
    //dictionar cu functie de executat pentru fiecare functie
    public delegate void execute(SimulatorParameters Sim);
    public static class SimulatorDictionary
    {
        public static Dictionary<string, execute> Dict = new Dictionary<string, execute>();

        public static void LoadSimulator()
        {
            Dict.Add("add", add);
            Dict.Add("j", jump);
            Dict.Add("sub", sub);
            Dict.Add("ori", ori);
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
            try
            {
                Sim.immediate = Convert.ToInt32(Sim.immediate, 2).ToString();
            }
            catch(Exception)
            {
                //in cazul instructiunilor jump adresa immediate primita in binar este 
                //convertita in zecimal la prima executare a instructiunii si
                //se arunca exceptie la urmatoarele executari deoarece stringul nu mai e in binar
            }
        }
        private static void sub(SimulatorParameters Sim)
        {
            int _rs = Convert.ToInt32(Sim.rs_value);
            int _rt = Convert.ToInt32(Sim.rt_value);

            Sim.rd_value = Convert.ToString(_rs - _rt);
            Sim.immediate = "";

        }
        private static void ori(SimulatorParameters Sim)
        {
            if(!String.IsNullOrEmpty(Sim.immediate))
            {
                Sim.immediate_as_value = Sim.immediate;
                Sim.immediate = null;
            }
            Sim.rd_name = Sim.rt_name;
            string rs_value_binary = Convert.ToString(Convert.ToInt32(Sim.rs_value), 2);
            if(Sim.immediate_as_value.Length != rs_value_binary.Length)
                if(Sim.immediate_as_value.Length > rs_value_binary.Length)
                {
                        rs_value_binary = rs_value_binary.PadLeft(Sim.immediate_as_value.Length, '0');
                }
                else
                {
                    Sim.immediate_as_value = Sim.immediate_as_value.PadLeft(rs_value_binary.Length, '0');
                }
            char[] immediate_as_value = Sim.immediate_as_value.ToCharArray();
            char[] rs_value = rs_value_binary.ToCharArray();
            char[] result_char = new char[immediate_as_value.Length];
            for (int i = 0; i < result_char.Length; i++)
                result_char[i] = Convert.ToChar(Convert.ToInt32(immediate_as_value[i]) | Convert.ToInt32(rs_value[i]));
            string result_string = new string(result_char);
            while (result_string.StartsWith("0"))
                result_string = result_string.Remove(0, 1);
            Sim.rd_value = Convert.ToString(Convert.ToInt32(result_string, 2));
        }
    }
}
