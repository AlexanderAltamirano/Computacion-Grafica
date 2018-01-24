namespace Ejercicio15
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDataA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstArrayA = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertA = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstArrayA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 381);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Array A";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDataA
            // 
            this.txtDataA.Location = new System.Drawing.Point(353, 32);
            this.txtDataA.Name = "txtDataA";
            this.txtDataA.Size = new System.Drawing.Size(100, 20);
            this.txtDataA.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Dato:";
            // 
            // lstArrayA
            // 
            this.lstArrayA.FormattingEnabled = true;
            this.lstArrayA.Location = new System.Drawing.Point(21, 45);
            this.lstArrayA.Name = "lstArrayA";
            this.lstArrayA.Size = new System.Drawing.Size(223, 329);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertA);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 58);
            this.groupBox1.TabIndex = 4;
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
            // btnRemoveData
            // 
            this.btnRemoveData.Location = new System.Drawing.Point(312, 76);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(127, 34);
            this.btnRemoveData.TabIndex = 8;
            this.btnRemoveData.Text = "Remover  Dato";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 471);
            this.Controls.Add(this.txtDataA);
            this.Controls.Add(this.btnRemoveData);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDataA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstArrayA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveData;
    }
}

