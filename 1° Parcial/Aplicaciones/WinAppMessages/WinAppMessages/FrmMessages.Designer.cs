namespace WinAppMessages
{
    partial class FrmMessages
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
            this.btnMessage1 = new System.Windows.Forms.Button();
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.btnMessage2 = new System.Windows.Forms.Button();
            this.btnMessage3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMessage1
            // 
            this.btnMessage1.Location = new System.Drawing.Point(47, 39);
            this.btnMessage1.Name = "btnMessage1";
            this.btnMessage1.Size = new System.Drawing.Size(139, 23);
            this.btnMessage1.TabIndex = 0;
            this.btnMessage1.Text = "Mostrar mensaje 1";
            this.btnMessage1.UseVisualStyleBackColor = true;
            this.btnMessage1.Click += new System.EventHandler(this.btnMessage1_Click);
            // 
            // grbMessage
            // 
            this.grbMessage.Controls.Add(this.btnExit);
            this.grbMessage.Controls.Add(this.btnMessage3);
            this.grbMessage.Controls.Add(this.btnMessage2);
            this.grbMessage.Controls.Add(this.btnMessage1);
            this.grbMessage.Location = new System.Drawing.Point(29, 12);
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.Size = new System.Drawing.Size(243, 277);
            this.grbMessage.TabIndex = 1;
            this.grbMessage.TabStop = false;
            // 
            // btnMessage2
            // 
            this.btnMessage2.Location = new System.Drawing.Point(47, 69);
            this.btnMessage2.Name = "btnMessage2";
            this.btnMessage2.Size = new System.Drawing.Size(139, 23);
            this.btnMessage2.TabIndex = 1;
            this.btnMessage2.Text = "Mostrar mensaje 2";
            this.btnMessage2.UseVisualStyleBackColor = true;
            this.btnMessage2.Click += new System.EventHandler(this.btnMessage2_Click);
            // 
            // btnMessage3
            // 
            this.btnMessage3.Location = new System.Drawing.Point(47, 99);
            this.btnMessage3.Name = "btnMessage3";
            this.btnMessage3.Size = new System.Drawing.Size(139, 23);
            this.btnMessage3.TabIndex = 2;
            this.btnMessage3.Text = "Mostrar mensaje 3";
            this.btnMessage3.UseVisualStyleBackColor = true;
            this.btnMessage3.Click += new System.EventHandler(this.btnMessage3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.grbMessage);
            this.Name = "FrmMessages";
            this.Text = "Manejo de Mensajes";
            this.Load += new System.EventHandler(this.FrmMessages_Load_1);
            this.grbMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessage1;
        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMessage3;
        private System.Windows.Forms.Button btnMessage2;
    }
}

