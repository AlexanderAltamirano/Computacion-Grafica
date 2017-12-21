namespace WinAppVectores2D
{
    partial class frmVectors2D
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gbrOperations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSustraction = new System.Windows.Forms.Button();
            this.btnAdition = new System.Windows.Forms.Button();
            this.txtImaginarioVectorR = new System.Windows.Forms.TextBox();
            this.txtRealVectorR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblImaginarioB = new System.Windows.Forms.Label();
            this.lblRealB = new System.Windows.Forms.Label();
            this.lblImaginario = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblSepator = new System.Windows.Forms.Label();
            this.nudRealVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudImaginarioVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudImaginarioVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudRealVectorA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VectorA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gbrOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImaginarioVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImaginarioVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealVectorA)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(12, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(426, 334);
            this.grbCanvas.TabIndex = 0;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Grafica";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 300);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbrOperations
            // 
            this.gbrOperations.Controls.Add(this.btnDivision);
            this.gbrOperations.Controls.Add(this.btnMultiplication);
            this.gbrOperations.Controls.Add(this.label5);
            this.gbrOperations.Controls.Add(this.label1);
            this.gbrOperations.Controls.Add(this.label3);
            this.gbrOperations.Controls.Add(this.btnExit);
            this.gbrOperations.Controls.Add(this.btnSustraction);
            this.gbrOperations.Controls.Add(this.btnAdition);
            this.gbrOperations.Controls.Add(this.txtImaginarioVectorR);
            this.gbrOperations.Controls.Add(this.txtRealVectorR);
            this.gbrOperations.Controls.Add(this.label6);
            this.gbrOperations.Controls.Add(this.lblImaginarioB);
            this.gbrOperations.Controls.Add(this.lblRealB);
            this.gbrOperations.Controls.Add(this.lblImaginario);
            this.gbrOperations.Controls.Add(this.lblReal);
            this.gbrOperations.Controls.Add(this.lblSepator);
            this.gbrOperations.Controls.Add(this.nudRealVectorB);
            this.gbrOperations.Controls.Add(this.nudImaginarioVectorB);
            this.gbrOperations.Controls.Add(this.nudImaginarioVectorA);
            this.gbrOperations.Controls.Add(this.nudRealVectorA);
            this.gbrOperations.Controls.Add(this.label2);
            this.gbrOperations.Controls.Add(this.VectorA);
            this.gbrOperations.Location = new System.Drawing.Point(444, 5);
            this.gbrOperations.Name = "gbrOperations";
            this.gbrOperations.Size = new System.Drawing.Size(268, 334);
            this.gbrOperations.TabIndex = 1;
            this.gbrOperations.TabStop = false;
            this.gbrOperations.Text = "Operaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(183, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Imaginario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Real";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(30, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 25);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSustraction
            // 
            this.btnSustraction.Location = new System.Drawing.Point(139, 139);
            this.btnSustraction.Name = "btnSustraction";
            this.btnSustraction.Size = new System.Drawing.Size(20, 23);
            this.btnSustraction.TabIndex = 15;
            this.btnSustraction.Text = "-";
            this.btnSustraction.UseVisualStyleBackColor = true;
            this.btnSustraction.Click += new System.EventHandler(this.btnSustraction_Click);
            // 
            // btnAdition
            // 
            this.btnAdition.Location = new System.Drawing.Point(90, 139);
            this.btnAdition.Name = "btnAdition";
            this.btnAdition.Size = new System.Drawing.Size(20, 23);
            this.btnAdition.TabIndex = 14;
            this.btnAdition.Text = "+";
            this.btnAdition.UseVisualStyleBackColor = true;
            this.btnAdition.Click += new System.EventHandler(this.btnAdition_Click);
            // 
            // txtImaginarioVectorR
            // 
            this.txtImaginarioVectorR.Enabled = false;
            this.txtImaginarioVectorR.Location = new System.Drawing.Point(186, 210);
            this.txtImaginarioVectorR.Name = "txtImaginarioVectorR";
            this.txtImaginarioVectorR.Size = new System.Drawing.Size(58, 20);
            this.txtImaginarioVectorR.TabIndex = 13;
            // 
            // txtRealVectorR
            // 
            this.txtRealVectorR.Enabled = false;
            this.txtRealVectorR.Location = new System.Drawing.Point(101, 210);
            this.txtRealVectorR.Name = "txtRealVectorR";
            this.txtRealVectorR.Size = new System.Drawing.Size(58, 20);
            this.txtRealVectorR.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(31, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VectorR";
            // 
            // lblImaginarioB
            // 
            this.lblImaginarioB.AutoSize = true;
            this.lblImaginarioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImaginarioB.ForeColor = System.Drawing.Color.Black;
            this.lblImaginarioB.Location = new System.Drawing.Point(199, 75);
            this.lblImaginarioB.Name = "lblImaginarioB";
            this.lblImaginarioB.Size = new System.Drawing.Size(10, 13);
            this.lblImaginarioB.TabIndex = 10;
            this.lblImaginarioB.Text = "i";
            // 
            // lblRealB
            // 
            this.lblRealB.AutoSize = true;
            this.lblRealB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealB.ForeColor = System.Drawing.Color.Black;
            this.lblRealB.Location = new System.Drawing.Point(115, 75);
            this.lblRealB.Name = "lblRealB";
            this.lblRealB.Size = new System.Drawing.Size(33, 13);
            this.lblRealB.TabIndex = 9;
            this.lblRealB.Text = "Real";
            // 
            // lblImaginario
            // 
            this.lblImaginario.AutoSize = true;
            this.lblImaginario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImaginario.ForeColor = System.Drawing.Color.Black;
            this.lblImaginario.Location = new System.Drawing.Point(199, 16);
            this.lblImaginario.Name = "lblImaginario";
            this.lblImaginario.Size = new System.Drawing.Size(10, 13);
            this.lblImaginario.TabIndex = 8;
            this.lblImaginario.Text = "i";
            this.lblImaginario.Click += new System.EventHandler(this.lblImaginario_Click);
            // 
            // lblReal
            // 
            this.lblReal.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.ForeColor = System.Drawing.Color.Black;
            this.lblReal.Location = new System.Drawing.Point(115, 16);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(33, 13);
            this.lblReal.TabIndex = 7;
            this.lblReal.Text = "Real";
            this.lblReal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSepator
            // 
            this.lblSepator.AutoSize = true;
            this.lblSepator.ForeColor = System.Drawing.Color.Black;
            this.lblSepator.Location = new System.Drawing.Point(31, 171);
            this.lblSepator.Name = "lblSepator";
            this.lblSepator.Size = new System.Drawing.Size(217, 13);
            this.lblSepator.TabIndex = 6;
            this.lblSepator.Text = "___________________________________";
            // 
            // nudRealVectorB
            // 
            this.nudRealVectorB.Location = new System.Drawing.Point(101, 91);
            this.nudRealVectorB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRealVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudRealVectorB.Name = "nudRealVectorB";
            this.nudRealVectorB.Size = new System.Drawing.Size(58, 20);
            this.nudRealVectorB.TabIndex = 5;
            // 
            // nudImaginarioVectorB
            // 
            this.nudImaginarioVectorB.Location = new System.Drawing.Point(178, 91);
            this.nudImaginarioVectorB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudImaginarioVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudImaginarioVectorB.Name = "nudImaginarioVectorB";
            this.nudImaginarioVectorB.Size = new System.Drawing.Size(58, 20);
            this.nudImaginarioVectorB.TabIndex = 4;
            // 
            // nudImaginarioVectorA
            // 
            this.nudImaginarioVectorA.Location = new System.Drawing.Point(178, 32);
            this.nudImaginarioVectorA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudImaginarioVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudImaginarioVectorA.Name = "nudImaginarioVectorA";
            this.nudImaginarioVectorA.Size = new System.Drawing.Size(58, 20);
            this.nudImaginarioVectorA.TabIndex = 3;
            // 
            // nudRealVectorA
            // 
            this.nudRealVectorA.Location = new System.Drawing.Point(101, 32);
            this.nudRealVectorA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRealVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudRealVectorA.Name = "nudRealVectorA";
            this.nudRealVectorA.Size = new System.Drawing.Size(58, 20);
            this.nudRealVectorA.TabIndex = 2;
            this.nudRealVectorA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VectorB";
            // 
            // VectorA
            // 
            this.VectorA.AutoSize = true;
            this.VectorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VectorA.ForeColor = System.Drawing.Color.Red;
            this.VectorA.Location = new System.Drawing.Point(27, 34);
            this.VectorA.Name = "VectorA";
            this.VectorA.Size = new System.Drawing.Size(52, 13);
            this.VectorA.TabIndex = 0;
            this.VectorA.Text = "VectorA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Operaciones: ";
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(178, 139);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(20, 23);
            this.btnMultiplication.TabIndex = 21;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(224, 139);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(20, 23);
            this.btnDivision.TabIndex = 22;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // frmVectors2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.gbrOperations);
            this.Controls.Add(this.grbCanvas);
            this.Name = "frmVectors2D";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmVectors2D_Load);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gbrOperations.ResumeLayout(false);
            this.gbrOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImaginarioVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImaginarioVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealVectorA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox gbrOperations;
        private System.Windows.Forms.NumericUpDown nudImaginarioVectorA;
        private System.Windows.Forms.NumericUpDown nudRealVectorA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VectorA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSustraction;
        private System.Windows.Forms.Button btnAdition;
        private System.Windows.Forms.TextBox txtImaginarioVectorR;
        private System.Windows.Forms.TextBox txtRealVectorR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImaginarioB;
        private System.Windows.Forms.Label lblRealB;
        private System.Windows.Forms.Label lblImaginario;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblSepator;
        private System.Windows.Forms.NumericUpDown nudRealVectorB;
        private System.Windows.Forms.NumericUpDown nudImaginarioVectorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Label label5;
    }
}

