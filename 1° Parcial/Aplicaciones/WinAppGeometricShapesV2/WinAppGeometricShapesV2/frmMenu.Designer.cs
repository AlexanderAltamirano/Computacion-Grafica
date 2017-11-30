namespace WinAppGeometricShapesV2
{
    partial class frmMenu
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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectrangle = new System.Windows.Forms.Button();
            this.btnSquart = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnTriangle);
            this.grbMenu.Controls.Add(this.btnSquart);
            this.grbMenu.Controls.Add(this.btnRectrangle);
            this.grbMenu.Controls.Add(this.btnCircle);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(346, 270);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(71, 31);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(203, 23);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circulo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectrangle
            // 
            this.btnRectrangle.Location = new System.Drawing.Point(71, 60);
            this.btnRectrangle.Name = "btnRectrangle";
            this.btnRectrangle.Size = new System.Drawing.Size(203, 23);
            this.btnRectrangle.TabIndex = 1;
            this.btnRectrangle.Text = "Rectangulo";
            this.btnRectrangle.UseVisualStyleBackColor = true;
            this.btnRectrangle.Click += new System.EventHandler(this.btnRectrangle_Click);
            // 
            // btnSquart
            // 
            this.btnSquart.Location = new System.Drawing.Point(71, 89);
            this.btnSquart.Name = "btnSquart";
            this.btnSquart.Size = new System.Drawing.Size(203, 23);
            this.btnSquart.TabIndex = 2;
            this.btnSquart.Text = "Cuadrado";
            this.btnSquart.UseVisualStyleBackColor = true;
            this.btnSquart.Click += new System.EventHandler(this.btnSquart_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(71, 118);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(203, 23);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Triangulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(71, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSquart;
        private System.Windows.Forms.Button btnRectrangle;
        private System.Windows.Forms.Button btnCircle;
    }
}

