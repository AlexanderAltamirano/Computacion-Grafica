namespace WinAppAstericsFigures
{
    partial class frmRectangle
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lstFigure = new System.Windows.Forms.ListBox();
            this.lblFigure = new System.Windows.Forms.Label();
            this.grbInput.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtB);
            this.grbInput.Controls.Add(this.lblB);
            this.grbInput.Controls.Add(this.txtA);
            this.grbInput.Controls.Add(this.lblA);
            this.grbInput.Location = new System.Drawing.Point(21, 22);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(260, 81);
            this.grbInput.TabIndex = 13;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(137, 48);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(27, 55);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(103, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Ingrese el valor de b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(137, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(27, 27);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(103, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Ingrese el valor de a";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(21, 109);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(260, 55);
            this.grbProcess.TabIndex = 14;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(179, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(96, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lstFigure);
            this.grbOutput.Controls.Add(this.lblFigure);
            this.grbOutput.Location = new System.Drawing.Point(21, 170);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(254, 247);
            this.grbOutput.TabIndex = 15;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Salidas";
            // 
            // lstFigure
            // 
            this.lstFigure.FormattingEnabled = true;
            this.lstFigure.Location = new System.Drawing.Point(15, 40);
            this.lstFigure.Name = "lstFigure";
            this.lstFigure.Size = new System.Drawing.Size(207, 186);
            this.lstFigure.TabIndex = 3;
            // 
            // lblFigure
            // 
            this.lblFigure.Location = new System.Drawing.Point(6, 14);
            this.lblFigure.Name = "lblFigure";
            this.lblFigure.Size = new System.Drawing.Size(100, 23);
            this.lblFigure.TabIndex = 4;
            this.lblFigure.Text = "Figura:";
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 425);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutput);
            this.Name = "frmRectangle";
            this.Text = "frmRectangle";
            this.Load += new System.EventHandler(this.frmRectangle_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.ListBox lstFigure;
        private System.Windows.Forms.Label lblFigure;
    }
}