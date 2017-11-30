namespace WinAppAstericsFigures
{
    partial class frmAsteriscsFigures
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
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnCheckboard = new System.Windows.Forms.Button();
            this.btnRhombus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(6, 47);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(196, 22);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "Cuadrado";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(6, 19);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(196, 22);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Círculo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnCheckboard);
            this.grbMenu.Controls.Add(this.btnRhombus);
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnTriangle);
            this.grbMenu.Controls.Add(this.btnRectangle);
            this.grbMenu.Controls.Add(this.btnSquare);
            this.grbMenu.Controls.Add(this.btnCircle);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(208, 231);
            this.grbMenu.TabIndex = 1;
            this.grbMenu.TabStop = false;
            // 
            // btnCheckboard
            // 
            this.btnCheckboard.Location = new System.Drawing.Point(6, 159);
            this.btnCheckboard.Name = "btnCheckboard";
            this.btnCheckboard.Size = new System.Drawing.Size(196, 22);
            this.btnCheckboard.TabIndex = 5;
            this.btnCheckboard.Text = "Tablero de Ajedrez";
            this.btnCheckboard.UseVisualStyleBackColor = true;
            this.btnCheckboard.Click += new System.EventHandler(this.btnCheckboard_Click);
            // 
            // btnRhombus
            // 
            this.btnRhombus.Location = new System.Drawing.Point(6, 131);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(196, 22);
            this.btnRhombus.TabIndex = 4;
            this.btnRhombus.Text = "Rombo";
            this.btnRhombus.UseVisualStyleBackColor = true;
            this.btnRhombus.Click += new System.EventHandler(this.btnRhombus_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 22);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(6, 103);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(196, 22);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Triángulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(6, 75);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(196, 22);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectángulo";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // frmAsteriscsFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 269);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmAsteriscsFigures";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.Button btnCheckboard;
    }
}

