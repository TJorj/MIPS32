namespace MIPS32
{
    partial class SimulatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProgramCounter = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblRegisters = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            this.lblT5 = new System.Windows.Forms.Label();
            this.lblT6 = new System.Windows.Forms.Label();
            this.lblT7 = new System.Windows.Forms.Label();
            this.lblT8 = new System.Windows.Forms.Label();
            this.lblT9 = new System.Windows.Forms.Label();
            this.lblT10 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.t1 = new Ionic.WinForms.RichTextBoxEx();
            this.t2 = new Ionic.WinForms.RichTextBoxEx();
            this.t3 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx4 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx5 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx6 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx7 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx8 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx9 = new Ionic.WinForms.RichTextBoxEx();
            this.richTextBoxEx10 = new Ionic.WinForms.RichTextBoxEx();
            this.txtBoxInstr = new Ionic.WinForms.RichTextBoxEx();
            this.txtBoxPC = new Ionic.WinForms.RichTextBoxEx();
            this.lblDebugger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProgramCounter
            // 
            this.lblProgramCounter.AutoSize = true;
            this.lblProgramCounter.Location = new System.Drawing.Point(13, 69);
            this.lblProgramCounter.Name = "lblProgramCounter";
            this.lblProgramCounter.Size = new System.Drawing.Size(116, 17);
            this.lblProgramCounter.TabIndex = 0;
            this.lblProgramCounter.Text = "Program Counter";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(271, 69);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(73, 17);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Instruction";
            // 
            // lblRegisters
            // 
            this.lblRegisters.AutoSize = true;
            this.lblRegisters.Location = new System.Drawing.Point(753, 13);
            this.lblRegisters.Name = "lblRegisters";
            this.lblRegisters.Size = new System.Drawing.Size(68, 17);
            this.lblRegisters.TabIndex = 2;
            this.lblRegisters.Text = "Registers";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(718, 42);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(28, 17);
            this.lblT1.TabIndex = 3;
            this.lblT1.Text = "$t1";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(718, 69);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(28, 17);
            this.lblT2.TabIndex = 4;
            this.lblT2.Text = "$t2";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Location = new System.Drawing.Point(718, 100);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(28, 17);
            this.lblT3.TabIndex = 5;
            this.lblT3.Text = "$t3";
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.Location = new System.Drawing.Point(718, 134);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(41, 17);
            this.lblT4.TabIndex = 6;
            this.lblT4.Text = "T4 = ";
            // 
            // lblT5
            // 
            this.lblT5.AutoSize = true;
            this.lblT5.Location = new System.Drawing.Point(718, 164);
            this.lblT5.Name = "lblT5";
            this.lblT5.Size = new System.Drawing.Size(41, 17);
            this.lblT5.TabIndex = 7;
            this.lblT5.Text = "T5 = ";
            // 
            // lblT6
            // 
            this.lblT6.AutoSize = true;
            this.lblT6.Location = new System.Drawing.Point(718, 195);
            this.lblT6.Name = "lblT6";
            this.lblT6.Size = new System.Drawing.Size(41, 17);
            this.lblT6.TabIndex = 8;
            this.lblT6.Text = "T6 = ";
            // 
            // lblT7
            // 
            this.lblT7.AutoSize = true;
            this.lblT7.Location = new System.Drawing.Point(718, 221);
            this.lblT7.Name = "lblT7";
            this.lblT7.Size = new System.Drawing.Size(41, 17);
            this.lblT7.TabIndex = 9;
            this.lblT7.Text = "T7 = ";
            // 
            // lblT8
            // 
            this.lblT8.AutoSize = true;
            this.lblT8.Location = new System.Drawing.Point(718, 255);
            this.lblT8.Name = "lblT8";
            this.lblT8.Size = new System.Drawing.Size(41, 17);
            this.lblT8.TabIndex = 10;
            this.lblT8.Text = "T8 = ";
            // 
            // lblT9
            // 
            this.lblT9.AutoSize = true;
            this.lblT9.Location = new System.Drawing.Point(718, 287);
            this.lblT9.Name = "lblT9";
            this.lblT9.Size = new System.Drawing.Size(41, 17);
            this.lblT9.TabIndex = 11;
            this.lblT9.Text = "T9 = ";
            // 
            // lblT10
            // 
            this.lblT10.AutoSize = true;
            this.lblT10.Location = new System.Drawing.Point(718, 319);
            this.lblT10.Name = "lblT10";
            this.lblT10.Size = new System.Drawing.Size(49, 17);
            this.lblT10.TabIndex = 12;
            this.lblT10.Text = "T10 = ";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(371, 337);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(161, 23);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Execute Instruction";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(765, 42);
            this.t1.Name = "t1";
            this.t1.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.t1.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.t1.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.t1.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.t1.NumberBorderThickness = 1F;
            this.t1.NumberColor = System.Drawing.Color.DarkGray;
            this.t1.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.NumberLeadingZeroes = false;
            this.t1.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.t1.NumberPadding = 2;
            this.t1.ShowLineNumbers = false;
            this.t1.Size = new System.Drawing.Size(146, 26);
            this.t1.TabIndex = 14;
            this.t1.Text = "";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(765, 69);
            this.t2.Name = "t2";
            this.t2.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.t2.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.t2.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.t2.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.t2.NumberBorderThickness = 1F;
            this.t2.NumberColor = System.Drawing.Color.DarkGray;
            this.t2.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.NumberLeadingZeroes = false;
            this.t2.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.t2.NumberPadding = 2;
            this.t2.ShowLineNumbers = false;
            this.t2.Size = new System.Drawing.Size(146, 26);
            this.t2.TabIndex = 15;
            this.t2.Text = "";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(765, 97);
            this.t3.Name = "t3";
            this.t3.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.t3.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.t3.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.t3.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.t3.NumberBorderThickness = 1F;
            this.t3.NumberColor = System.Drawing.Color.DarkGray;
            this.t3.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.NumberLeadingZeroes = false;
            this.t3.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.t3.NumberPadding = 2;
            this.t3.ShowLineNumbers = false;
            this.t3.Size = new System.Drawing.Size(146, 26);
            this.t3.TabIndex = 16;
            this.t3.Text = "";
            // 
            // richTextBoxEx4
            // 
            this.richTextBoxEx4.Location = new System.Drawing.Point(765, 125);
            this.richTextBoxEx4.Name = "richTextBoxEx4";
            this.richTextBoxEx4.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx4.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx4.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx4.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx4.NumberBorderThickness = 1F;
            this.richTextBoxEx4.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx4.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx4.NumberLeadingZeroes = false;
            this.richTextBoxEx4.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx4.NumberPadding = 2;
            this.richTextBoxEx4.ShowLineNumbers = false;
            this.richTextBoxEx4.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx4.TabIndex = 17;
            this.richTextBoxEx4.Text = "";
            // 
            // richTextBoxEx5
            // 
            this.richTextBoxEx5.Location = new System.Drawing.Point(765, 155);
            this.richTextBoxEx5.Name = "richTextBoxEx5";
            this.richTextBoxEx5.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx5.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx5.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx5.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx5.NumberBorderThickness = 1F;
            this.richTextBoxEx5.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx5.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx5.NumberLeadingZeroes = false;
            this.richTextBoxEx5.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx5.NumberPadding = 2;
            this.richTextBoxEx5.ShowLineNumbers = false;
            this.richTextBoxEx5.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx5.TabIndex = 18;
            this.richTextBoxEx5.Text = "";
            // 
            // richTextBoxEx6
            // 
            this.richTextBoxEx6.Location = new System.Drawing.Point(765, 186);
            this.richTextBoxEx6.Name = "richTextBoxEx6";
            this.richTextBoxEx6.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx6.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx6.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx6.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx6.NumberBorderThickness = 1F;
            this.richTextBoxEx6.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx6.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx6.NumberLeadingZeroes = false;
            this.richTextBoxEx6.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx6.NumberPadding = 2;
            this.richTextBoxEx6.ShowLineNumbers = false;
            this.richTextBoxEx6.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx6.TabIndex = 19;
            this.richTextBoxEx6.Text = "";
            // 
            // richTextBoxEx7
            // 
            this.richTextBoxEx7.Location = new System.Drawing.Point(765, 218);
            this.richTextBoxEx7.Name = "richTextBoxEx7";
            this.richTextBoxEx7.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx7.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx7.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx7.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx7.NumberBorderThickness = 1F;
            this.richTextBoxEx7.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx7.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx7.NumberLeadingZeroes = false;
            this.richTextBoxEx7.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx7.NumberPadding = 2;
            this.richTextBoxEx7.ShowLineNumbers = false;
            this.richTextBoxEx7.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx7.TabIndex = 20;
            this.richTextBoxEx7.Text = "";
            // 
            // richTextBoxEx8
            // 
            this.richTextBoxEx8.Location = new System.Drawing.Point(765, 252);
            this.richTextBoxEx8.Name = "richTextBoxEx8";
            this.richTextBoxEx8.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx8.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx8.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx8.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx8.NumberBorderThickness = 1F;
            this.richTextBoxEx8.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx8.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx8.NumberLeadingZeroes = false;
            this.richTextBoxEx8.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx8.NumberPadding = 2;
            this.richTextBoxEx8.ShowLineNumbers = false;
            this.richTextBoxEx8.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx8.TabIndex = 21;
            this.richTextBoxEx8.Text = "";
            // 
            // richTextBoxEx9
            // 
            this.richTextBoxEx9.Location = new System.Drawing.Point(765, 284);
            this.richTextBoxEx9.Name = "richTextBoxEx9";
            this.richTextBoxEx9.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx9.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx9.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx9.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx9.NumberBorderThickness = 1F;
            this.richTextBoxEx9.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx9.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx9.NumberLeadingZeroes = false;
            this.richTextBoxEx9.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx9.NumberPadding = 2;
            this.richTextBoxEx9.ShowLineNumbers = false;
            this.richTextBoxEx9.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx9.TabIndex = 22;
            this.richTextBoxEx9.Text = "";
            // 
            // richTextBoxEx10
            // 
            this.richTextBoxEx10.Location = new System.Drawing.Point(765, 316);
            this.richTextBoxEx10.Name = "richTextBoxEx10";
            this.richTextBoxEx10.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx10.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx10.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx10.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx10.NumberBorderThickness = 1F;
            this.richTextBoxEx10.NumberColor = System.Drawing.Color.DarkGray;
            this.richTextBoxEx10.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx10.NumberLeadingZeroes = false;
            this.richTextBoxEx10.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx10.NumberPadding = 2;
            this.richTextBoxEx10.ShowLineNumbers = false;
            this.richTextBoxEx10.Size = new System.Drawing.Size(146, 26);
            this.richTextBoxEx10.TabIndex = 23;
            this.richTextBoxEx10.Text = "";
            // 
            // txtBoxInstr
            // 
            this.txtBoxInstr.Location = new System.Drawing.Point(227, 97);
            this.txtBoxInstr.Name = "txtBoxInstr";
            this.txtBoxInstr.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtBoxInstr.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.txtBoxInstr.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.txtBoxInstr.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.txtBoxInstr.NumberBorderThickness = 1F;
            this.txtBoxInstr.NumberColor = System.Drawing.Color.DarkGray;
            this.txtBoxInstr.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInstr.NumberLeadingZeroes = false;
            this.txtBoxInstr.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtBoxInstr.NumberPadding = 2;
            this.txtBoxInstr.ShowLineNumbers = false;
            this.txtBoxInstr.Size = new System.Drawing.Size(448, 234);
            this.txtBoxInstr.TabIndex = 24;
            this.txtBoxInstr.Text = "";
            // 
            // txtBoxPC
            // 
            this.txtBoxPC.Location = new System.Drawing.Point(12, 97);
            this.txtBoxPC.Name = "txtBoxPC";
            this.txtBoxPC.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtBoxPC.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.txtBoxPC.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.txtBoxPC.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.txtBoxPC.NumberBorderThickness = 1F;
            this.txtBoxPC.NumberColor = System.Drawing.Color.DarkGray;
            this.txtBoxPC.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPC.NumberLeadingZeroes = false;
            this.txtBoxPC.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtBoxPC.NumberPadding = 2;
            this.txtBoxPC.ShowLineNumbers = false;
            this.txtBoxPC.Size = new System.Drawing.Size(209, 234);
            this.txtBoxPC.TabIndex = 25;
            this.txtBoxPC.Text = "";
            // 
            // lblDebugger
            // 
            this.lblDebugger.AutoSize = true;
            this.lblDebugger.Location = new System.Drawing.Point(50, 25);
            this.lblDebugger.Name = "lblDebugger";
            this.lblDebugger.Size = new System.Drawing.Size(71, 17);
            this.lblDebugger.TabIndex = 26;
            this.lblDebugger.Text = "Denugger";
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 372);
            this.Controls.Add(this.lblDebugger);
            this.Controls.Add(this.txtBoxPC);
            this.Controls.Add(this.txtBoxInstr);
            this.Controls.Add(this.richTextBoxEx10);
            this.Controls.Add(this.richTextBoxEx9);
            this.Controls.Add(this.richTextBoxEx8);
            this.Controls.Add(this.richTextBoxEx7);
            this.Controls.Add(this.richTextBoxEx6);
            this.Controls.Add(this.richTextBoxEx5);
            this.Controls.Add(this.richTextBoxEx4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblT10);
            this.Controls.Add(this.lblT9);
            this.Controls.Add(this.lblT8);
            this.Controls.Add(this.lblT7);
            this.Controls.Add(this.lblT6);
            this.Controls.Add(this.lblT5);
            this.Controls.Add(this.lblT4);
            this.Controls.Add(this.lblT3);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.lblRegisters);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblProgramCounter);
            this.Name = "SimulatorForm";
            this.Text = "SimulatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramCounter;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblRegisters;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblT5;
        private System.Windows.Forms.Label lblT6;
        private System.Windows.Forms.Label lblT7;
        private System.Windows.Forms.Label lblT8;
        private System.Windows.Forms.Label lblT9;
        private System.Windows.Forms.Label lblT10;
        private System.Windows.Forms.Button btnExecute;
        private Ionic.WinForms.RichTextBoxEx t1;
        private Ionic.WinForms.RichTextBoxEx t2;
        private Ionic.WinForms.RichTextBoxEx t3;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx4;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx5;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx6;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx7;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx8;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx9;
        private Ionic.WinForms.RichTextBoxEx richTextBoxEx10;
        private Ionic.WinForms.RichTextBoxEx txtBoxInstr;
        private Ionic.WinForms.RichTextBoxEx txtBoxPC;
        private System.Windows.Forms.Label lblDebugger;
    }
}