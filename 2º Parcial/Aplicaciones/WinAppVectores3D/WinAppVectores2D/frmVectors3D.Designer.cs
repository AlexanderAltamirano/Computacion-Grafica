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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZVectorR = new System.Windows.Forms.TextBox();
            this.nudZVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudZVectorA = new System.Windows.Forms.NumericUpDown();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSustraction = new System.Windows.Forms.Button();
            this.btnAdition = new System.Windows.Forms.Button();
            this.txtYVectorR = new System.Windows.Forms.TextBox();
            this.txtXVectorR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSepator = new System.Windows.Forms.Label();
            this.nudXVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VectorA = new System.Windows.Forms.Label();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gbrOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(12, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(413, 334);
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
            this.gbrOperations.Controls.Add(this.label10);
            this.gbrOperations.Controls.Add(this.label11);
            this.gbrOperations.Controls.Add(this.label12);
            this.gbrOperations.Controls.Add(this.label7);
            this.gbrOperations.Controls.Add(this.label8);
            this.gbrOperations.Controls.Add(this.label9);
            this.gbrOperations.Controls.Add(this.label4);
            this.gbrOperations.Controls.Add(this.txtZVectorR);
            this.gbrOperations.Controls.Add(this.nudZVectorB);
            this.gbrOperations.Controls.Add(this.nudZVectorA);
            this.gbrOperations.Controls.Add(this.btnDivision);
            this.gbrOperations.Controls.Add(this.btnMultiplication);
            this.gbrOperations.Controls.Add(this.label5);
            this.gbrOperations.Controls.Add(this.label1);
            this.gbrOperations.Controls.Add(this.label3);
            this.gbrOperations.Controls.Add(this.btnExit);
            this.gbrOperations.Controls.Add(this.btnSustraction);
            this.gbrOperations.Controls.Add(this.btnAdition);
            this.gbrOperations.Controls.Add(this.txtYVectorR);
            this.gbrOperations.Controls.Add(this.txtXVectorR);
            this.gbrOperations.Controls.Add(this.label6);
            this.gbrOperations.Controls.Add(this.lblSepator);
            this.gbrOperations.Controls.Add(this.nudXVectorB);
            this.gbrOperations.Controls.Add(this.nudYVectorB);
            this.gbrOperations.Controls.Add(this.nudYVectorA);
            this.gbrOperations.Controls.Add(this.nudXVectorA);
            this.gbrOperations.Controls.Add(this.label2);
            this.gbrOperations.Controls.Add(this.VectorA);
            this.gbrOperations.Location = new System.Drawing.Point(431, 5);
            this.gbrOperations.Name = "gbrOperations";
            this.gbrOperations.Size = new System.Drawing.Size(281, 334);
            this.gbrOperations.TabIndex = 1;
            this.gbrOperations.TabStop = false;
            this.gbrOperations.Text = "Operaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(229, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(160, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(95, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(229, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(95, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(229, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Z";
            // 
            // txtZVectorR
            // 
            this.txtZVectorR.Enabled = false;
            this.txtZVectorR.Location = new System.Drawing.Point(206, 210);
            this.txtZVectorR.Name = "txtZVectorR";
            this.txtZVectorR.Size = new System.Drawing.Size(58, 20);
            this.txtZVectorR.TabIndex = 25;
            // 
            // nudZVectorB
            // 
            this.nudZVectorB.Location = new System.Drawing.Point(206, 91);
            this.nudZVectorB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudZVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudZVectorB.Name = "nudZVectorB";
            this.nudZVectorB.Size = new System.Drawing.Size(58, 20);
            this.nudZVectorB.TabIndex = 24;
            // 
            // nudZVectorA
            // 
            this.nudZVectorA.Location = new System.Drawing.Point(206, 32);
            this.nudZVectorA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudZVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudZVectorA.Name = "nudZVectorA";
            this.nudZVectorA.Size = new System.Drawing.Size(58, 20);
            this.nudZVectorA.TabIndex = 23;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(224, 139);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(20, 23);
            this.btnDivision.TabIndex = 22;
            this.btnDivision.Text = "X";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Operaciones: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(160, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "X";
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
            // txtYVectorR
            // 
            this.txtYVectorR.Enabled = false;
            this.txtYVectorR.Location = new System.Drawing.Point(142, 210);
            this.txtYVectorR.Name = "txtYVectorR";
            this.txtYVectorR.Size = new System.Drawing.Size(58, 20);
            this.txtYVectorR.TabIndex = 13;
            // 
            // txtXVectorR
            // 
            this.txtXVectorR.Enabled = false;
            this.txtXVectorR.Location = new System.Drawing.Point(78, 210);
            this.txtXVectorR.Name = "txtXVectorR";
            this.txtXVectorR.Size = new System.Drawing.Size(58, 20);
            this.txtXVectorR.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(11, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VectorR";
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
            // nudXVectorB
            // 
            this.nudXVectorB.Location = new System.Drawing.Point(78, 91);
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
            this.nudXVectorB.Size = new System.Drawing.Size(58, 20);
            this.nudXVectorB.TabIndex = 5;
            // 
            // nudYVectorB
            // 
            this.nudYVectorB.Location = new System.Drawing.Point(139, 91);
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
            this.nudYVectorB.Size = new System.Drawing.Size(58, 20);
            this.nudYVectorB.TabIndex = 4;
            // 
            // nudYVectorA
            // 
            this.nudYVectorA.Location = new System.Drawing.Point(142, 32);
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
            this.nudYVectorA.Size = new System.Drawing.Size(58, 20);
            this.nudYVectorA.TabIndex = 3;
            // 
            // nudXVectorA
            // 
            this.nudXVectorA.Location = new System.Drawing.Point(78, 32);
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
            this.nudXVectorA.Size = new System.Drawing.Size(58, 20);
            this.nudXVectorA.TabIndex = 2;
            this.nudXVectorA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 93);
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
            this.VectorA.Location = new System.Drawing.Point(11, 34);
            this.VectorA.Name = "VectorA";
            this.VectorA.Size = new System.Drawing.Size(52, 13);
            this.VectorA.TabIndex = 0;
            this.VectorA.Text = "VectorA";
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
            ((System.ComponentModel.ISupportInitialize)(this.nudZVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox gbrOperations;
        private System.Windows.Forms.NumericUpDown nudYVectorA;
        private System.Windows.Forms.NumericUpDown nudXVectorA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VectorA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSustraction;
        private System.Windows.Forms.Button btnAdition;
        private System.Windows.Forms.TextBox txtYVectorR;
        private System.Windows.Forms.TextBox txtXVectorR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSepator;
        private System.Windows.Forms.NumericUpDown nudXVectorB;
        private System.Windows.Forms.NumericUpDown nudYVectorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZVectorR;
        private System.Windows.Forms.NumericUpDown nudZVectorB;
        private System.Windows.Forms.NumericUpDown nudZVectorA;
    }
}

