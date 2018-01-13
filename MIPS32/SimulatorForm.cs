using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIPS32
{
    public partial class SimulatorForm : Form
    {
        private int i = 0;
        Control[] controls;
        public SimulatorForm()
        {
            InitializeComponent();
            string tmp_instr;
            int tmp_pc = -4;
            while (SimulatorDisplayQueue.InstructionsDisplay.Count != 0)
            {
                tmp_instr = SimulatorDisplayQueue.InstructionsDisplay.Dequeue();
                txtBoxInstr.AppendText(tmp_instr);
                txtBoxInstr.AppendText(Environment.NewLine);

                tmp_pc = tmp_pc + 4;
                txtBoxPC.AppendText(Convert.ToString(tmp_pc,16));
                txtBoxPC.AppendText(Environment.NewLine);
            }
            ColorCurrentLine(i, Color.Red);
            pc.Text = SimulatorList.ListToExecute[i].pc;
            t1.Text = "3";
            t2.Text = "1";
            t3.Text = "1";
            

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            SimulatorParameters sim = SimulatorList.ListToExecute[i];
           
            if (!String.IsNullOrEmpty(sim.rt_name)&&!String.Equals(TextParser.GetGenericRegisterName(),sim.rt_name))
            { 
                controls = this.Controls.Find(sim.rt_name, true);
                sim.rt_value = controls[0].Text;
            }
            if (!String.IsNullOrEmpty(sim.rs_name) && !String.Equals(TextParser.GetGenericRegisterName(), sim.rt_name))
            {
                controls = this.Controls.Find(sim.rs_name, true);
                sim.rs_value = controls[0].Text;
       
            }
            try
            {
                SimulatorDictionary.Dict[sim.operation].Invoke(sim);
            }
            catch(Exception)
            {
                lblDebugger.Text = "Unimplemented operation " + sim.operation;
            }
            if (!String.IsNullOrEmpty(sim.rd_name) && !String.Equals(TextParser.GetGenericRegisterName(), sim.rt_name))
            {
                controls = this.Controls.Find(sim.rd_name, true);
                controls[0].Text = sim.rd_value;
              
            }
            if (String.IsNullOrEmpty(sim.immediate))
            {
                i++;
            }
            else
            {
               
                i = (SimulatorList.ListToExecute.FindIndex(delegate (SimulatorParameters find) { return find.pc.ToString() == sim.immediate; }));
  
            }

            pc.Text = Convert.ToString(Convert.ToInt32(SimulatorList.ListToExecute[i].pc),16);
            ColorCurrentLine(i, Color.Red);
        }

        private void ColorCurrentLine(int i, Color color)
        {
            txtBoxInstr.SelectAll();
            txtBoxInstr.SelectionBackColor = Color.White;
            var lines = txtBoxInstr.Lines;
            if (i < 0 || i >= lines.Length)
                return;
            var start = txtBoxInstr.GetFirstCharIndexFromLine(i);
            var length = lines[i].Length;
            txtBoxInstr.Select(start, length);
            txtBoxInstr.SelectionBackColor = color;
        }
        private void OnClose(object sender, EventArgs e)
        {
            SimulatorDisplayQueue.Clear();
            SimulatorList.ListToExecute.Clear();
        }
    }
}
