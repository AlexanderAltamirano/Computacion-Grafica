namespace WinApp361
{
    partial class frmMenu
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
            this.btnFuncion1 = new System.Windows.Forms.Button();
            this.btnFuncion3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFuncion2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFuncion1
            // 
            this.btnFuncion1.Location = new System.Drawing.Point(29, 21);
            this.btnFuncion1.Name = "btnFuncion1";
            this.btnFuncion1.Size = new System.Drawing.Size(165, 23);
            this.btnFuncion1.TabIndex = 0;
            this.btnFuncion1.Text = "x=t-cos5t , y=t+sen7t";
            this.btnFuncion1.UseVisualStyleBackColor = true;
            this.btnFuncion1.Click += new System.EventHandler(this.btnFuncion1_Click);
            // 
            // btnFuncion3
            // 
            this.btnFuncion3.Location = new System.Drawing.Point(29, 75);
            this.btnFuncion3.Name = "btnFuncion3";
            this.btnFuncion3.Size = new System.Drawing.Size(165, 23);
            this.btnFuncion3.TabIndex = 2;
            this.btnFuncion3.Text = "x=sen7tcos10t, y=sen7tcos10t";
            this.btnFuncion3.UseVisualStyleBackColor = true;
            this.btnFuncion3.Click += new System.EventHandler(this.btnFuncion3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFuncion2
            // 
            this.btnFuncion2.Location = new System.Drawing.Point(29, 46);
            this.btnFuncion2.Name = "btnFuncion2";
            this.btnFuncion2.Size = new System.Drawing.Size(165, 23);
            this.btnFuncion2.TabIndex = 1;
            this.btnFuncion2.Text = "x=cos5t, y=sent7t";
            this.btnFuncion2.UseVisualStyleBackColor = true;
            this.btnFuncion2.Click += new System.EventHandler(this.btnFuncion2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFuncion1);
            this.groupBox1.Controls.Add(this.btnFuncion3);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnFuncion2);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncion1;
        private System.Windows.Forms.Button btnFuncion3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFuncion2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

