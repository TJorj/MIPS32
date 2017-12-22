using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 0 pt shamt
/// </summary>
namespace MIPS32
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssemble_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < txtBoxMnemonics.Lines.Count(); i++)
            {
                string text = txtBoxMnemonics.Lines[i];
                if (!String.IsNullOrEmpty(text))
                {
                    text = TextParser.LineParse(text);
                    txtBoxMachineCode.AppendText(text);
                    txtBoxMachineCode.AppendText(Environment.NewLine);
                }
                //string pattern = Patterns.instruction_name + Patterns.paranthesis_open + Patterns.register_name + Patterns.nonalphanumerical + Patterns.register_name + Patterns.nonalphanumerical + Patterns.register_name + Patterns.paranthesis_close;
                //Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                //MatchCollection matches = rgx.Matches(text);
                //GroupCollection groups = matches[0].Groups;
                //CaptureCollection captures = groups["nume_reg"].Captures;
                //txtBoxMachineCode.AppendText(Instructions.Collections[groups["nume_instr"].Value.Replace(" ", "")].Opcode + " " + Registers.Collections[captures[0].Value.Replace(" ", "")].Number + " " + Registers.Collections[captures[1].Value.Replace(" ", "")].Number + " " + Registers.Collections[captures[2].Value.Replace(" ", "")].Number + " " + Instructions.Collections[groups["nume_instr"].Value.Replace(" ", "")].Funct);
                //txtBoxMachineCode.AppendText(Environment.NewLine);
            }

        }
    }
}
