namespace WinAppArraysOperations
{
    partial class frmArraysOperations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertA = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMediaA = new System.Windows.Forms.TextBox();
            this.txtSigmaA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstArrayA = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediaB = new System.Windows.Forms.TextBox();
            this.btnInsertB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstArrayB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSigmaB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMediaC = new System.Windows.Forms.TextBox();
            this.btnInsertC = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lstArrayC = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSigmaC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGenerateRandomArray = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSigma = new System.Windows.Forms.Button();
            this.txtDataA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertA);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Array A";
            // 
            // btnInsertA
            // 
            this.btnInsertA.Location = new System.Drawing.Point(169, 16);
            this.btnInsertA.Name = "btnInsertA";
            this.btnInsertA.Size = new System.Drawing.Size(75, 23);
            this.btnInsertA.TabIndex = 2;
            this.btnInsertA.Text = "Insertar";
            this.btnInsertA.UseVisualStyleBackColor = true;
            this.btnInsertA.Click += new System.EventHandler(this.btnInsertA_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(96, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(67, 20);
            this.txtA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un dato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataA);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMediaA);
            this.groupBox2.Controls.Add(this.txtSigmaA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstArrayA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Array A";
            // 
            // txtMediaA
            // 
            this.txtMediaA.Location = new System.Drawing.Point(110, 310);
            this.txtMediaA.Name = "txtMediaA";
            this.txtMediaA.Size = new System.Drawing.Size(100, 20);
            this.txtMediaA.TabIndex = 8;
            // 
            // txtSigmaA
            // 
            this.txtSigmaA.Location = new System.Drawing.Point(110, 284);
            this.txtSigmaA.Name = "txtSigmaA";
            this.txtSigmaA.Size = new System.Drawing.Size(100, 20);
            this.txtSigmaA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sumatoria:";
            // 
            // lstArrayA
            // 
            this.lstArrayA.FormattingEnabled = true;
            this.lstArrayA.Location = new System.Drawing.Point(46, 45);
            this.lstArrayA.Name = "lstArrayA";
            this.lstArrayA.Size = new System.Drawing.Size(164, 225);
            this.lstArrayA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(96, 19);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(67, 20);
            this.txtB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese un dato:";
            // 
            // txtMediaB
            // 
            this.txtMediaB.Location = new System.Drawing.Point(110, 310);
            this.txtMediaB.Name = "txtMediaB";
            this.txtMediaB.Size = new System.Drawing.Size(100, 20);
            this.txtMediaB.TabIndex = 8;
            // 
            // btnInsertB
            // 
            this.btnInsertB.Location = new System.Drawing.Point(169, 16);
            this.btnInsertB.Name = "btnInsertB";
            this.btnInsertB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertB.TabIndex = 2;
            this.btnInsertB.Text = "Insertar";
            this.btnInsertB.UseVisualStyleBackColor = true;
            this.btnInsertB.Click += new System.EventHandler(this.btnInsertB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Promedio:";
            // 
            // lstArrayB
            // 
            this.lstArrayB.FormattingEnabled = true;
            this.lstArrayB.Location = new System.Drawing.Point(46, 45);
            this.lstArrayB.Name = "lstArrayB";
            this.lstArrayB.Size = new System.Drawing.Size(164, 225);
            this.lstArrayB.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMediaB);
            this.groupBox3.Controls.Add(this.txtSigmaB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lstArrayB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(277, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 358);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Array B";
            // 
            // txtSigmaB
            // 
            this.txtSigmaB.Location = new System.Drawing.Point(110, 284);
            this.txtSigmaB.Name = "txtSigmaB";
            this.txtSigmaB.Size = new System.Drawing.Size(100, 20);
            this.txtSigmaB.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sumatoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Datos:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsertB);
            this.groupBox4.Controls.Add(this.txtB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(277, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 58);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Array B";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(96, 19);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(67, 20);
            this.txtC.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ingrese un dato:";
            // 
            // txtMediaC
            // 
            this.txtMediaC.Location = new System.Drawing.Point(110, 310);
            this.txtMediaC.Name = "txtMediaC";
            this.txtMediaC.Size = new System.Drawing.Size(100, 20);
            this.txtMediaC.TabIndex = 8;
            // 
            // btnInsertC
            // 
            this.btnInsertC.Location = new System.Drawing.Point(169, 16);
            this.btnInsertC.Name = "btnInsertC";
            this.btnInsertC.Size = new System.Drawing.Size(75, 23);
            this.btnInsertC.TabIndex = 2;
            this.btnInsertC.Text = "Insertar";
            this.btnInsertC.UseVisualStyleBackColor = true;
            this.btnInsertC.Click += new System.EventHandler(this.btnInsertC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Promedio:";
            // 
            // lstArrayC
            // 
            this.lstArrayC.FormattingEnabled = true;
            this.lstArrayC.Location = new System.Drawing.Point(46, 45);
            this.lstArrayC.Name = "lstArrayC";
            this.lstArrayC.Size = new System.Drawing.Size(164, 225);
            this.lstArrayC.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMediaC);
            this.groupBox5.Controls.Add(this.txtSigmaC);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lstArrayC);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(542, 76);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 358);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Array C";
            // 
            // txtSigmaC
            // 
            this.txtSigmaC.Location = new System.Drawing.Point(110, 284);
            this.txtSigmaC.Name = "txtSigmaC";
            this.txtSigmaC.Size = new System.Drawing.Size(100, 20);
            this.txtSigmaC.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Sumatoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Datos:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInsertC);
            this.groupBox6.Controls.Add(this.txtC);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(542, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 58);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Array C";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRemoveData);
            this.groupBox7.Controls.Add(this.btnGenerateRandomArray);
            this.groupBox7.Controls.Add(this.btnExit);
            this.groupBox7.Controls.Add(this.btnSort);
            this.groupBox7.Controls.Add(this.btnReverse);
            this.groupBox7.Controls.Add(this.btnCopy);
            this.groupBox7.Controls.Add(this.btnMedia);
            this.groupBox7.Controls.Add(this.btnSigma);
            this.groupBox7.Location = new System.Drawing.Point(807, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(166, 422);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // btnGenerateRandomArray
            // 
            this.btnGenerateRandomArray.Location = new System.Drawing.Point(19, 264);
            this.btnGenerateRandomArray.Name = "btnGenerateRandomArray";
            this.btnGenerateRandomArray.Size = new System.Drawing.Size(127, 34);
            this.btnGenerateRandomArray.TabIndex = 6;
            this.btnGenerateRandomArray.Text = "Array Aleatorio";
            this.btnGenerateRandomArray.UseVisualStyleBackColor = true;
            this.btnGenerateRandomArray.Click += new System.EventHandler(this.btnGenerateRandomArray_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(19, 184);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(127, 34);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(19, 144);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(127, 34);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Invertir";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(19, 104);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(127, 34);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(19, 64);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(127, 34);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Promedio";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSigma
            // 
            this.btnSigma.Location = new System.Drawing.Point(19, 23);
            this.btnSigma.Name = "btnSigma";
            this.btnSigma.Size = new System.Drawing.Size(127, 34);
            this.btnSigma.TabIndex = 0;
            this.btnSigma.Text = "Sumatoria";
            this.btnSigma.UseVisualStyleBackColor = true;
            this.btnSigma.Click += new System.EventHandler(this.btnSigma_Click);
            // 
            // txtDataA
            // 
            this.txtDataA.Location = new System.Drawing.Point(110, 338);
            this.txtDataA.Name = "txtDataA";
            this.txtDataA.Size = new System.Drawing.Size(100, 20);
            this.txtDataA.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Dato:";
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Location = new System.Drawing.Point(19, 224);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(127, 34);
            this.btnRemoveData.TabIndex = 7;
            this.btnRemoveData.Text = "Remover Dato";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // frmArraysOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 483);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArraysOperations";
            this.Text = "Operaciones con Arreglos";
            this.Load += new System.EventHandler(this.frmArraysOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMediaA;
        private System.Windows.Forms.TextBox txtSigmaA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstArrayA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMediaB;
        private System.Windows.Forms.Button btnInsertB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstArrayB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSigmaB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMediaC;
        private System.Windows.Forms.Button btnInsertC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstArrayC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSigmaC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSigma;
        private System.Windows.Forms.Button btnGenerateRandomArray;
        private System.Windows.Forms.TextBox txtDataA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemoveData;
    }
}

