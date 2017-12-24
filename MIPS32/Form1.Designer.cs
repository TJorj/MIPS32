namespace MIPS32
{
    partial class Form1
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
            this.btnAssemble = new System.Windows.Forms.Button();
            this.txtBoxMnemonics = new System.Windows.Forms.TextBox();
            this.txtBoxMachineCode = new System.Windows.Forms.TextBox();
            this.txtBoxErrors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAssemble
            // 
            this.btnAssemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssemble.Location = new System.Drawing.Point(269, 12);
            this.btnAssemble.Name = "btnAssemble";
            this.btnAssemble.Size = new System.Drawing.Size(430, 33);
            this.btnAssemble.TabIndex = 0;
            this.btnAssemble.Text = "Assemble";
            this.btnAssemble.UseVisualStyleBackColor = true;
            this.btnAssemble.Click += new System.EventHandler(this.btnAssemble_Click);
            // 
            // txtBoxMnemonics
            // 
            this.txtBoxMnemonics.AcceptsReturn = true;
            this.txtBoxMnemonics.AcceptsTab = true;
            this.txtBoxMnemonics.Location = new System.Drawing.Point(33, 99);
            this.txtBoxMnemonics.Multiline = true;
            this.txtBoxMnemonics.Name = "txtBoxMnemonics";
            this.txtBoxMnemonics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxMnemonics.Size = new System.Drawing.Size(333, 264);
            this.txtBoxMnemonics.TabIndex = 1;
            this.txtBoxMnemonics.Text = "add($t1,$t2,$t3)\r\nsub($t1,$t2,$t3)";
            this.txtBoxMnemonics.WordWrap = false;
            // 
            // txtBoxMachineCode
            // 
            this.txtBoxMachineCode.AcceptsReturn = true;
            this.txtBoxMachineCode.AcceptsTab = true;
            this.txtBoxMachineCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMachineCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMachineCode.Location = new System.Drawing.Point(607, 99);
            this.txtBoxMachineCode.Multiline = true;
            this.txtBoxMachineCode.Name = "txtBoxMachineCode";
            this.txtBoxMachineCode.ReadOnly = true;
            this.txtBoxMachineCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxMachineCode.Size = new System.Drawing.Size(333, 264);
            this.txtBoxMachineCode.TabIndex = 2;
            this.txtBoxMachineCode.WordWrap = false;
            // 
            // txtBoxErrors
            // 
            this.txtBoxErrors.AcceptsReturn = true;
            this.txtBoxErrors.AcceptsTab = true;
            this.txtBoxErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxErrors.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxErrors.Location = new System.Drawing.Point(33, 420);
            this.txtBoxErrors.Multiline = true;
            this.txtBoxErrors.Name = "txtBoxErrors";
            this.txtBoxErrors.ReadOnly = true;
            this.txtBoxErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxErrors.Size = new System.Drawing.Size(898, 86);
            this.txtBoxErrors.TabIndex = 3;
            this.txtBoxErrors.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 529);
            this.Controls.Add(this.txtBoxErrors);
            this.Controls.Add(this.txtBoxMachineCode);
            this.Controls.Add(this.txtBoxMnemonics);
            this.Controls.Add(this.btnAssemble);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssemble;
        private System.Windows.Forms.TextBox txtBoxMnemonics;
        private System.Windows.Forms.TextBox txtBoxMachineCode;
        private System.Windows.Forms.TextBox txtBoxErrors;
    }
}

