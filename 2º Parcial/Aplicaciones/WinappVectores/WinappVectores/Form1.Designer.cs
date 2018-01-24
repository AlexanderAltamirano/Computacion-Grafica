namespace WinappVectores
{
    partial class frmVectpr2D
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.lblVectorA = new System.Windows.Forms.Label();
            this.lblVectorB = new System.Windows.Forms.Label();
            this.nudXVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorB = new System.Windows.Forms.NumericUpDown();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblVectorR = new System.Windows.Forms.Label();
            this.txtXVectorR = new System.Windows.Forms.TextBox();
            this.txtYVectorR = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(12, 12);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(427, 327);
            this.grbCanvas.TabIndex = 0;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 300);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnExit);
            this.grbOperations.Controls.Add(this.btnSubtraction);
            this.grbOperations.Controls.Add(this.btnAddition);
            this.grbOperations.Controls.Add(this.txtYVectorR);
            this.grbOperations.Controls.Add(this.txtXVectorR);
            this.grbOperations.Controls.Add(this.lblVectorR);
            this.grbOperations.Controls.Add(this.lblY);
            this.grbOperations.Controls.Add(this.lblX);
            this.grbOperations.Controls.Add(this.lblSeparator);
            this.grbOperations.Controls.Add(this.nudYVectorB);
            this.grbOperations.Controls.Add(this.nudXVectorB);
            this.grbOperations.Controls.Add(this.nudYVectorA);
            this.grbOperations.Controls.Add(this.nudXVectorA);
            this.grbOperations.Controls.Add(this.lblVectorB);
            this.grbOperations.Controls.Add(this.lblVectorA);
            this.grbOperations.Location = new System.Drawing.Point(456, 12);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(256, 327);
            this.grbOperations.TabIndex = 1;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "Operaciones";
            // 
            // lblVectorA
            // 
            this.lblVectorA.AutoSize = true;
            this.lblVectorA.ForeColor = System.Drawing.Color.Red;
            this.lblVectorA.Location = new System.Drawing.Point(15, 42);
            this.lblVectorA.Name = "lblVectorA";
            this.lblVectorA.Size = new System.Drawing.Size(51, 13);
            this.lblVectorA.TabIndex = 0;
            this.lblVectorA.Text = "Vector A:";
            // 
            // lblVectorB
            // 
            this.lblVectorB.AutoSize = true;
            this.lblVectorB.ForeColor = System.Drawing.Color.Blue;
            this.lblVectorB.Location = new System.Drawing.Point(15, 72);
            this.lblVectorB.Name = "lblVectorB";
            this.lblVectorB.Size = new System.Drawing.Size(51, 13);
            this.lblVectorB.TabIndex = 1;
            this.lblVectorB.Text = "Vector B:";
            // 
            // nudXVectorA
            // 
            this.nudXVectorA.Location = new System.Drawing.Point(72, 40);
            this.nudXVectorA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudXVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudXVectorA.Name = "nudXVectorA";
            this.nudXVectorA.Size = new System.Drawing.Size(53, 20);
            this.nudXVectorA.TabIndex = 2;
            // 
            // nudYVectorA
            // 
            this.nudYVectorA.Location = new System.Drawing.Point(131, 40);
            this.nudYVectorA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudYVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudYVectorA.Name = "nudYVectorA";
            this.nudYVectorA.Size = new System.Drawing.Size(53, 20);
            this.nudYVectorA.TabIndex = 3;
            // 
            // nudYVectorB
            // 
            this.nudYVectorB.Location = new System.Drawing.Point(131, 70);
            this.nudYVectorB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudYVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudYVectorB.Name = "nudYVectorB";
            this.nudYVectorB.Size = new System.Drawing.Size(53, 20);
            this.nudYVectorB.TabIndex = 5;
            // 
            // nudXVectorB
            // 
            this.nudXVectorB.Location = new System.Drawing.Point(72, 70);
            this.nudXVectorB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudXVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudXVectorB.Name = "nudXVectorB";
            this.nudXVectorB.Size = new System.Drawing.Size(53, 20);
            this.nudXVectorB.TabIndex = 4;
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(6, 93);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(235, 13);
            this.lblSeparator.TabIndex = 6;
            this.lblSeparator.Text = "______________________________________";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblX.Location = new System.Drawing.Point(89, 19);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblY.Location = new System.Drawing.Point(145, 19);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 13);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y";
            // 
            // lblVectorR
            // 
            this.lblVectorR.AutoSize = true;
            this.lblVectorR.ForeColor = System.Drawing.Color.Lime;
            this.lblVectorR.Location = new System.Drawing.Point(15, 118);
            this.lblVectorR.Name = "lblVectorR";
            this.lblVectorR.Size = new System.Drawing.Size(52, 13);
            this.lblVectorR.TabIndex = 9;
            this.lblVectorR.Text = "Vector R:";
            // 
            // txtXVectorR
            // 
            this.txtXVectorR.Enabled = false;
            this.txtXVectorR.Location = new System.Drawing.Point(72, 115);
            this.txtXVectorR.Name = "txtXVectorR";
            this.txtXVectorR.Size = new System.Drawing.Size(53, 20);
            this.txtXVectorR.TabIndex = 10;
            // 
            // txtYVectorR
            // 
            this.txtYVectorR.Enabled = false;
            this.txtYVectorR.Location = new System.Drawing.Point(131, 115);
            this.txtYVectorR.Name = "txtYVectorR";
            this.txtYVectorR.Size = new System.Drawing.Size(53, 20);
            this.txtYVectorR.TabIndex = 11;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(206, 37);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(20, 23);
            this.btnAddition.TabIndex = 12;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(206, 67);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(20, 23);
            this.btnSubtraction.TabIndex = 13;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(45, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 32);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVectpr2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.grbOperations);
            this.Controls.Add(this.grbCanvas);
            this.Name = "frmVectpr2D";
            this.Text = "Operaciones con Vectores 2D";
            this.Load += new System.EventHandler(this.frmVectpr2D_Load);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbOperations.ResumeLayout(false);
            this.grbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Label lblVectorB;
        private System.Windows.Forms.Label lblVectorA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtYVectorR;
        private System.Windows.Forms.TextBox txtXVectorR;
        private System.Windows.Forms.Label lblVectorR;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.NumericUpDown nudYVectorB;
        private System.Windows.Forms.NumericUpDown nudXVectorB;
        private System.Windows.Forms.NumericUpDown nudYVectorA;
        private System.Windows.Forms.NumericUpDown nudXVectorA;
    }
}

