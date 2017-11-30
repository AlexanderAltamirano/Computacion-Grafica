namespace WinAppAstericsFigures
{
    partial class frmTriangle
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstTriangle = new System.Windows.Forms.ListBox();
            this.grbInput.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtNum);
            this.grbInput.Controls.Add(this.lblSide1);
            this.grbInput.Location = new System.Drawing.Point(25, 27);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(364, 67);
            this.grbInput.TabIndex = 4;
            this.grbInput.TabStop = false;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(226, 22);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(24, 22);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(71, 17);
            this.lblSide1.TabIndex = 0;
            this.lblSide1.Text = "Ingrese n:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(25, 100);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(364, 79);
            this.grbProcess.TabIndex = 5;
            this.grbProcess.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(135, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(26, 31);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 35);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstTriangle
            // 
            this.lstTriangle.FormattingEnabled = true;
            this.lstTriangle.ItemHeight = 16;
            this.lstTriangle.Location = new System.Drawing.Point(25, 200);
            this.lstTriangle.Name = "lstTriangle";
            this.lstTriangle.Size = new System.Drawing.Size(364, 212);
            this.lstTriangle.TabIndex = 6;
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 431);
            this.Controls.Add(this.lstTriangle);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbProcess);
            this.Name = "frmTriangle";
            this.Text = "frmTriangle";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstTriangle;
    }
}