namespace WinAppPlotFunctions
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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRationalFunction = new System.Windows.Forms.Button();
            this.btnRoseFourPetals = new System.Windows.Forms.Button();
            this.btnSinFunction = new System.Windows.Forms.Button();
            this.btnCuadraticFunction = new System.Windows.Forms.Button();
            this.btnParametricFunction = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnParametricFunction);
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnRationalFunction);
            this.grbMenu.Controls.Add(this.btnRoseFourPetals);
            this.grbMenu.Controls.Add(this.btnSinFunction);
            this.grbMenu.Controls.Add(this.btnCuadraticFunction);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(260, 292);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRationalFunction
            // 
            this.btnRationalFunction.Location = new System.Drawing.Point(18, 151);
            this.btnRationalFunction.Name = "btnRationalFunction";
            this.btnRationalFunction.Size = new System.Drawing.Size(225, 38);
            this.btnRationalFunction.TabIndex = 3;
            this.btnRationalFunction.Text = "Función Racional";
            this.btnRationalFunction.UseVisualStyleBackColor = true;
            this.btnRationalFunction.Click += new System.EventHandler(this.btnRationalFunction_Click);
            // 
            // btnRoseFourPetals
            // 
            this.btnRoseFourPetals.Location = new System.Drawing.Point(18, 107);
            this.btnRoseFourPetals.Name = "btnRoseFourPetals";
            this.btnRoseFourPetals.Size = new System.Drawing.Size(225, 38);
            this.btnRoseFourPetals.TabIndex = 2;
            this.btnRoseFourPetals.Text = "Rosa de 4 Pétalos";
            this.btnRoseFourPetals.UseVisualStyleBackColor = true;
            this.btnRoseFourPetals.Click += new System.EventHandler(this.btnRoseFourPetals_Click);
            // 
            // btnSinFunction
            // 
            this.btnSinFunction.Location = new System.Drawing.Point(18, 63);
            this.btnSinFunction.Name = "btnSinFunction";
            this.btnSinFunction.Size = new System.Drawing.Size(225, 38);
            this.btnSinFunction.TabIndex = 1;
            this.btnSinFunction.Text = "Función Seno";
            this.btnSinFunction.UseVisualStyleBackColor = true;
            this.btnSinFunction.Click += new System.EventHandler(this.btnSinFunction_Click);
            // 
            // btnCuadraticFunction
            // 
            this.btnCuadraticFunction.Location = new System.Drawing.Point(18, 19);
            this.btnCuadraticFunction.Name = "btnCuadraticFunction";
            this.btnCuadraticFunction.Size = new System.Drawing.Size(225, 38);
            this.btnCuadraticFunction.TabIndex = 0;
            this.btnCuadraticFunction.Text = "Función Cuadrática";
            this.btnCuadraticFunction.UseVisualStyleBackColor = true;
            this.btnCuadraticFunction.Click += new System.EventHandler(this.btnCuadraticFunction_Click);
            // 
            // btnParametricFunction
            // 
            this.btnParametricFunction.Location = new System.Drawing.Point(18, 192);
            this.btnParametricFunction.Name = "btnParametricFunction";
            this.btnParametricFunction.Size = new System.Drawing.Size(225, 38);
            this.btnParametricFunction.TabIndex = 5;
            this.btnParametricFunction.Text = "Función Paramétrica";
            this.btnParametricFunction.UseVisualStyleBackColor = true;
            this.btnParametricFunction.Click += new System.EventHandler(this.btnParametricFunction_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
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
        private System.Windows.Forms.Button btnRationalFunction;
        private System.Windows.Forms.Button btnRoseFourPetals;
        private System.Windows.Forms.Button btnSinFunction;
        private System.Windows.Forms.Button btnCuadraticFunction;
        private System.Windows.Forms.Button btnParametricFunction;
    }
}

