namespace MIPS32
{
    partial class AssemblerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTxtBoxCode = new System.Windows.Forms.Panel();
            this.txtBoxMnemonics = new Ionic.WinForms.RichTextBoxEx();
            this.panelTxtBoxMachine = new System.Windows.Forms.Panel();
            this.txtBoxMachineCode = new Ionic.WinForms.RichTextBoxEx();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelTxtBoxErrors = new System.Windows.Forms.Panel();
            this.txtBoxErrors = new Ionic.WinForms.RichTextBoxEx();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelTxtBoxCode.SuspendLayout();
            this.panelTxtBoxMachine.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.panelTxtBoxErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.saveToolStripMenuItem2,
            this.loadToolStripMenuItem2,
            this.assembleToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // assembleToolStripMenuItem
            // 
            this.assembleToolStripMenuItem.Name = "assembleToolStripMenuItem";
            this.assembleToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.assembleToolStripMenuItem.Text = "Assemble";
            this.assembleToolStripMenuItem.Click += new System.EventHandler(this.assembleToolStripMenuItem_Click);
            // 
            // panelTxtBoxCode
            // 
            this.panelTxtBoxCode.Controls.Add(this.txtBoxMnemonics);
            this.panelTxtBoxCode.Location = new System.Drawing.Point(27, 89);
            this.panelTxtBoxCode.Name = "panelTxtBoxCode";
            this.panelTxtBoxCode.Size = new System.Drawing.Size(457, 240);
            this.panelTxtBoxCode.TabIndex = 10;
            // 
            // txtBoxMnemonics
            // 
            this.txtBoxMnemonics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMnemonics.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxMnemonics.Location = new System.Drawing.Point(0, 0);
            this.txtBoxMnemonics.Name = "txtBoxMnemonics";
            this.txtBoxMnemonics.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtBoxMnemonics.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.txtBoxMnemonics.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.txtBoxMnemonics.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.txtBoxMnemonics.NumberBorderThickness = 1F;
            this.txtBoxMnemonics.NumberColor = System.Drawing.Color.Black;
            this.txtBoxMnemonics.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMnemonics.NumberLeadingZeroes = false;
            this.txtBoxMnemonics.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtBoxMnemonics.NumberPadding = 2;
            this.txtBoxMnemonics.ShowLineNumbers = true;
            this.txtBoxMnemonics.Size = new System.Drawing.Size(457, 240);
            this.txtBoxMnemonics.TabIndex = 0;
            this.txtBoxMnemonics.Text = "add $t1 $t2 $t3";
            // 
            // panelTxtBoxMachine
            // 
            this.panelTxtBoxMachine.Controls.Add(this.txtBoxMachineCode);
            this.panelTxtBoxMachine.Location = new System.Drawing.Point(484, 89);
            this.panelTxtBoxMachine.Name = "panelTxtBoxMachine";
            this.panelTxtBoxMachine.Size = new System.Drawing.Size(457, 240);
            this.panelTxtBoxMachine.TabIndex = 11;
            // 
            // txtBoxMachineCode
            // 
            this.txtBoxMachineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMachineCode.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxMachineCode.Location = new System.Drawing.Point(0, 0);
            this.txtBoxMachineCode.Name = "txtBoxMachineCode";
            this.txtBoxMachineCode.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtBoxMachineCode.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.txtBoxMachineCode.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.txtBoxMachineCode.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.txtBoxMachineCode.NumberBorderThickness = 1F;
            this.txtBoxMachineCode.NumberColor = System.Drawing.Color.DarkGray;
            this.txtBoxMachineCode.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMachineCode.NumberLeadingZeroes = false;
            this.txtBoxMachineCode.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtBoxMachineCode.NumberPadding = 2;
            this.txtBoxMachineCode.ReadOnly = true;
            this.txtBoxMachineCode.ShowLineNumbers = false;
            this.txtBoxMachineCode.Size = new System.Drawing.Size(457, 240);
            this.txtBoxMachineCode.TabIndex = 0;
            this.txtBoxMachineCode.Text = "";
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelWorkspace.Controls.Add(this.panelTxtBoxErrors);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 0);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(982, 529);
            this.panelWorkspace.TabIndex = 12;
            // 
            // panelTxtBoxErrors
            // 
            this.panelTxtBoxErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTxtBoxErrors.AutoSize = true;
            this.panelTxtBoxErrors.Controls.Add(this.txtBoxErrors);
            this.panelTxtBoxErrors.Location = new System.Drawing.Point(27, 353);
            this.panelTxtBoxErrors.Name = "panelTxtBoxErrors";
            this.panelTxtBoxErrors.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelTxtBoxErrors.Size = new System.Drawing.Size(913, 173);
            this.panelTxtBoxErrors.TabIndex = 0;
            // 
            // txtBoxErrors
            // 
            this.txtBoxErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxErrors.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxErrors.Location = new System.Drawing.Point(0, 0);
            this.txtBoxErrors.Name = "txtBoxErrors";
            this.txtBoxErrors.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtBoxErrors.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.txtBoxErrors.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.txtBoxErrors.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.txtBoxErrors.NumberBorderThickness = 1F;
            this.txtBoxErrors.NumberColor = System.Drawing.Color.DarkGray;
            this.txtBoxErrors.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxErrors.NumberLeadingZeroes = false;
            this.txtBoxErrors.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtBoxErrors.NumberPadding = 2;
            this.txtBoxErrors.ReadOnly = true;
            this.txtBoxErrors.ShowLineNumbers = false;
            this.txtBoxErrors.Size = new System.Drawing.Size(913, 143);
            this.txtBoxErrors.TabIndex = 0;
            this.txtBoxErrors.Text = "";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(54, 24);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // assembleToolStripMenuItem1
            // 
            this.assembleToolStripMenuItem1.Name = "assembleToolStripMenuItem1";
            this.assembleToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.assembleToolStripMenuItem1.Text = "Assemble";
            this.assembleToolStripMenuItem1.Click += new System.EventHandler(this.assembleToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(51, 24);
            this.newToolStripMenuItem2.Text = "New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem2
            // 
            this.loadToolStripMenuItem2.Name = "loadToolStripMenuItem2";
            this.loadToolStripMenuItem2.Size = new System.Drawing.Size(54, 24);
            this.loadToolStripMenuItem2.Text = "Load";
            this.loadToolStripMenuItem2.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // assembleToolStripMenuItem2
            // 
            this.assembleToolStripMenuItem2.Name = "assembleToolStripMenuItem2";
            this.assembleToolStripMenuItem2.Size = new System.Drawing.Size(85, 24);
            this.assembleToolStripMenuItem2.Text = "Assemble";
            this.assembleToolStripMenuItem2.Click += new System.EventHandler(this.assembleToolStripMenuItem_Click);
            // 
            // AssemblerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 529);
            this.Controls.Add(this.panelTxtBoxCode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTxtBoxMachine);
            this.Controls.Add(this.panelWorkspace);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AssemblerForm";
            this.Text = "MIPS32 Assembler";
            this.Load += new System.EventHandler(this.AssemblerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTxtBoxCode.ResumeLayout(false);
            this.panelTxtBoxMachine.ResumeLayout(false);
            this.panelWorkspace.ResumeLayout(false);
            this.panelWorkspace.PerformLayout();
            this.panelTxtBoxErrors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assembleToolStripMenuItem;
        private System.Windows.Forms.Panel panelTxtBoxCode;
        private System.Windows.Forms.Panel panelTxtBoxMachine;
        private System.Windows.Forms.Panel panelWorkspace;
        private Ionic.WinForms.RichTextBoxEx txtBoxMnemonics;
        private Ionic.WinForms.RichTextBoxEx txtBoxMachineCode;
        private System.Windows.Forms.Panel panelTxtBoxErrors;
        private Ionic.WinForms.RichTextBoxEx txtBoxErrors;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assembleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem assembleToolStripMenuItem2;
    }
}

