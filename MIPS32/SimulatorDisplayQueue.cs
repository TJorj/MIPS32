﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
