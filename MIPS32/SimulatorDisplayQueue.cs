using System.Collections.Generic;

namespace MIPS32
{
    public static class SimulatorDisplayQueue
    {
      //coada pentru afisarea grafica a instructiunilor in simulator
      public static  Queue<string> InstructionsDisplay = new Queue<string>();
      public static void Clear()
        {
            InstructionsDisplay.Clear();
        }
    }
}
