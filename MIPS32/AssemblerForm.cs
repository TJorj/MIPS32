using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
namespace MIPS32
{
    public partial class AssemblerForm : Form
    {

        public AssemblerForm()
        {
            InitializeComponent();
            UpdateControls(null,null);
           
            this.Resize += UpdateControls;
        }
        private void PanelBTN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssemblerForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimulatorDisplayQueue.Clear();
            SimulatorList.ListToExecute.Clear();
            txtBoxMachineCode.Clear();
            txtBoxErrors.Clear();
            for (int i = 0; i < txtBoxMnemonics.Lines.Count(); i++)
            {
                string text = txtBoxMnemonics.Lines[i];
                if (!String.IsNullOrEmpty(text))
                {
                    try
                    {
                        text = TextParser.LineParse(text);
                        txtBoxMachineCode.AppendText(text);

                    }
                    catch (InstructionException ex)
                    {
                        FormatErrorText(ex.Message, i);

                    }
                    catch (ParameterException ex)
                    {
                        FormatErrorText(ex.Message, i);

                    }
                    txtBoxMachineCode.AppendText(Environment.NewLine);
                }
            }
        }

        private void FormatErrorText(string text, int line_number)
        {
            string[] temp = text.Split(' ');
            for (int j = 0; j < temp.Length - 1; j++)
            {
                txtBoxErrors.AppendText(temp[j]);
                txtBoxErrors.AppendText(" ");
            }
            txtBoxErrors.AppendColorText(temp[temp.Length - 1], Color.Red);

            txtBoxErrors.AppendText(" on line ");
            txtBoxErrors.AppendColorText((line_number + 1).ToString(), Color.Red);
            txtBoxErrors.AppendText(Environment.NewLine);
        }

        private void TxtBoxMachineCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxErrors_TextChanged(object sender, EventArgs e)
        {
            
   
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved changes will be lost. Continue?", "New File", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtBoxMnemonics.Clear();
                txtBoxMachineCode.Clear();
                txtBoxErrors.Clear();
            }

        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             
        }
        private void UpdateControls(object sender, EventArgs e)
        {
            panelTxtBoxCode.Left = panelWorkspace.Left + 30;
            panelTxtBoxCode.Top = panelWorkspace.Top + menuStrip1.Height + 30;
            panelTxtBoxCode.Height = panelWorkspace.Height - 30 - menuStrip1.Height - txtBoxErrors.Height - 30;
            panelTxtBoxCode.Width = (panelWorkspace.Width - 60) / 2;

            panelTxtBoxMachine.Left = panelTxtBoxCode.Right;
            panelTxtBoxMachine.Top = panelWorkspace.Top + menuStrip1.Height + 30;
            panelTxtBoxMachine.Height = panelWorkspace.Height - 30 - menuStrip1.Height - txtBoxErrors.Height - 30;
            panelTxtBoxMachine.Width = (panelWorkspace.Width - 60) / 2;

            panelTxtBoxErrors.Left = panelWorkspace.Left + 30;
            panelTxtBoxErrors.Top = panelTxtBoxCode.Bottom ;
            panelTxtBoxErrors.Width = (panelWorkspace.Width - 60);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void assembleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void customFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load Instructions Code";
            openFileDialog.Filter = "TXT files|*.txt";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    txtBoxErrors.Clear();
                    txtBoxMachineCode.Clear();
                    txtBoxMnemonics.Clear();
                    string line;
                    using (stream)
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            txtBoxMnemonics.AppendText(line);
                            txtBoxMnemonics.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todosi George Vasile\nGrupa 3131B\nCalculatoare\nAn 3","Author Info");
        }

        private void instructionsDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved changes will be lost. Continue?", "Load File", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtBoxMachineCode.Clear();
                txtBoxErrors.Clear();
                txtBoxMnemonics.Clear();
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream("MIPS32.instructions_demo.txt"))
                using (StreamReader inFile = new StreamReader(stream))
                {
                    while (!inFile.EndOfStream)
                    {
                        string line = inFile.ReadLine();
                        txtBoxMnemonics.AppendText(line);
                        txtBoxMnemonics.AppendText(Environment.NewLine);
                    }
                }
            }
        }

        private void errorsDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved changes will be lost. Continue?", "Load File", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtBoxMachineCode.Clear();
                txtBoxErrors.Clear();
                txtBoxMnemonics.Clear();
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream("MIPS32.errors_demo.txt"))
                using (StreamReader inFile = new StreamReader(stream))
                {
                    while (!inFile.EndOfStream)
                    {
                        string line = inFile.ReadLine();
                        txtBoxMnemonics.AppendText(line);
                        txtBoxMnemonics.AppendText(Environment.NewLine);
                    }
                }
            }
        }

        private void assembledCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Assembled Code";
            saveFileDialog.FileName = "assembled_code.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = txtBoxMachineCode.Lines;
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    foreach (string line in tmp)
                        sw.WriteLine(line);
                }
            }
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Source Code";
            saveFileDialog.FileName = "source_code.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = txtBoxMnemonics.Lines;
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    foreach (string line in tmp)
                        sw.WriteLine(line);
                }
            }
        }

        private void simulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimulatorForm Form2 = new SimulatorForm();

           
            
            Form2.Show();
        }
    }

}
