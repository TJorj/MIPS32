using System.Collections.Generic;

namespace MIPS32
{
    public static class SimulatorDisplayQueue
    {
      public static  Queue<string> InstructionsDisplay = new Queue<string>();
      public static void Clear()
        {
            InstructionsDisplay.Clear();
        }
    }
}
