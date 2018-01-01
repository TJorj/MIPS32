using System;
using System.Windows.Forms;

namespace MIPS32
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Instructions.LoadInstructions();
            Registers.LoadRegisters();
            SimulatorInstructions.LoadSimulator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AssemblerForm());
        }
    }
}
