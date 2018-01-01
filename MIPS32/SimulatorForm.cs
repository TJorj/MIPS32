using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPS32
{
    public partial class SimulatorForm : Form
    {
        private int i = 0;
        private string pc="";
        Control[] controls;
        string rd_value;
        string rt;
        string rs_value;
        public SimulatorForm()
        {
            InitializeComponent();
            string tmp_instr;
            int tmp_pc = -4;
            while (SimulatorDisplayQueue.InstructionsDispaly.Count != 0)
            {
                tmp_instr = SimulatorDisplayQueue.InstructionsDispaly.Dequeue();
                txtBoxInstr.AppendText(tmp_instr);
                txtBoxInstr.AppendText(Environment.NewLine);

                tmp_pc = tmp_pc + 4;
                txtBoxPC.AppendText((tmp_pc).ToString());
                txtBoxPC.AppendText(Environment.NewLine);
            }
            t1.Text = "3";
            t2.Text = "1";
            t3.Text = "1";
            

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            SimulatorParameters sim = SimulatorList.ListToExecute[i];
            sim.rd = sim.rd.Trim('$');
            sim.rs = sim.rs.Trim('$');
            sim.rt = sim.rt.Trim('$');
            
            if (!String.IsNullOrEmpty(sim.rt))
            { 
                controls = this.Controls.Find(sim.rt, true);
                rt = controls[0].Text;
            }
            if (!String.IsNullOrEmpty(sim.rs))
            {
                controls = this.Controls.Find(sim.rs, true);
                rs_value = controls[0].Text;
       
            }
            try
            {
                SimulatorInstructions.Dict[sim.operation].Invoke(rs_value, rt, out rd_value, sim.shamt, sim.immediate, out pc);
            }
            catch(Exception)
            {
                lblDebugger.Text = sim.operation;
            }
            if (!String.IsNullOrEmpty(sim.rd))
            {
                controls = this.Controls.Find(sim.rd, true);
                controls[0].Text = rd_value;
              
            }
            if (String.IsNullOrEmpty(pc))
            {
                i++;
            }
            else
            {
               
                i = (SimulatorList.ListToExecute.FindIndex(delegate (SimulatorParameters find) { return find.pc.ToString() == pc; }));
               // lblDebugger.Text += pc + " pula " + i + " ";
            }

        }
    }
}
