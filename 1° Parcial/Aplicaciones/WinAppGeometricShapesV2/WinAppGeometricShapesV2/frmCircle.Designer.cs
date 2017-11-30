namespace WinAppGeometricShapesV2
{
    partial class frmCircle
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutPuts = new System.Windows.Forms.GroupBox();
            this.grbArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutPuts.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtRadius);
            this.grbInputs.Controls.Add(this.lblRadius);
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(375, 69);
            this.grbInputs.TabIndex = 3;
            this.grbInputs.TabStop = false;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(111, 32);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(23, 35);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(82, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Ingrese el radio:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(12, 87);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(375, 58);
            this.grbProcess.TabIndex = 4;
            this.grbProcess.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutPuts
            // 
            this.grbOutPuts.Controls.Add(this.grbArea);
            this.grbOutPuts.Controls.Add(this.txtArea);
            this.grbOutPuts.Controls.Add(this.lblArea);
            this.grbOutPuts.Controls.Add(this.txtPerimeter);
            this.grbOutPuts.Controls.Add(this.lblPerimeter);
            this.grbOutPuts.Location = new System.Drawing.Point(12, 151);
            this.grbOutPuts.Name = "grbOutPuts";
            this.grbOutPuts.Size = new System.Drawing.Size(375, 100);
            this.grbOutPuts.TabIndex = 5;
            this.grbOutPuts.TabStop = false;
            // 
            // grbArea
            // 
            this.grbArea.AutoSize = true;
            this.grbArea.Location = new System.Drawing.Point(23, 48);
            this.grbArea.Name = "grbArea";
            this.grbArea.Size = new System.Drawing.Size(32, 13);
            this.grbArea.TabIndex = 8;
            this.grbArea.Text = "Area:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(111, 45);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 7;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(23, 65);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(10, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = " ";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(111, 19);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 5;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(23, 22);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
            this.lblPerimeter.TabIndex = 4;
            this.lblPerimeter.Text = "Perimetro:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(403, 12);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(336, 239);
            this.grbCanvas.TabIndex = 6;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(22, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(300, 200);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutPuts);
            this.Name = "frmCircle";
            this.Text = "Circulo";
            this.Load += new System.EventHandler(this.frmCircle_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutPuts.ResumeLayout(false);
            this.grbOutPuts.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutPuts;
        private System.Windows.Forms.Label grbArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}