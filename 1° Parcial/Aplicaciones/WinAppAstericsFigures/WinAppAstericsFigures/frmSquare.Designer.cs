namespace WinAppAstericsFigures
{
    partial class frmSquare
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
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.grbFigure = new System.Windows.Forms.GroupBox();
            this.lstFigure = new System.Windows.Forms.ListBox();
            this.grbProcess.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(12, 74);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(245, 50);
            this.grbProcess.TabIndex = 9;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(81, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 19);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 16);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(69, 19);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtNum);
            this.grbInput.Controls.Add(this.lblSide);
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(245, 56);
            this.grbInput.TabIndex = 8;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entrada";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(131, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(86, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(19, 26);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(106, 13);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Ingrese el valor de n:";
            // 
            // grbFigure
            // 
            this.grbFigure.Controls.Add(this.lstFigure);
            this.grbFigure.Location = new System.Drawing.Point(12, 130);
            this.grbFigure.Name = "grbFigure";
            this.grbFigure.Size = new System.Drawing.Size(245, 273);
            this.grbFigure.TabIndex = 10;
            this.grbFigure.TabStop = false;
            this.grbFigure.Text = "Salida";
            // 
            // lstFigure
            // 
            this.lstFigure.FormattingEnabled = true;
            this.lstFigure.Location = new System.Drawing.Point(3, 16);
            this.lstFigure.Name = "lstFigure";
            this.lstFigure.Size = new System.Drawing.Size(236, 251);
            this.lstFigure.TabIndex = 0;
            // 
            // frmSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(269, 413);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbFigure);
            this.Name = "frmSquare";
            this.Text = "Cuadrado";
            this.Load += new System.EventHandler(this.frmSquare_Load);
            this.grbProcess.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbFigure.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.GroupBox grbFigure;
        private System.Windows.Forms.ListBox lstFigure;
    }
}