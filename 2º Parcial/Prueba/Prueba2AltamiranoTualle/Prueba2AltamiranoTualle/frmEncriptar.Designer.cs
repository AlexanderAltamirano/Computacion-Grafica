namespace Prueba2AltamiranoTualle
{
    partial class frmEncriptar
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
            this.lstProcess = new System.Windows.Forms.ListBox();
            this.lstEncrypt = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.grbEncrypt = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbInputs.SuspendLayout();
            this.grbEncrypt.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProcess
            // 
            this.lstProcess.FormattingEnabled = true;
            this.lstProcess.Location = new System.Drawing.Point(6, 19);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(295, 342);
            this.lstProcess.TabIndex = 7;
            // 
            // lstEncrypt
            // 
            this.lstEncrypt.FormattingEnabled = true;
            this.lstEncrypt.Location = new System.Drawing.Point(6, 25);
            this.lstEncrypt.Name = "lstEncrypt";
            this.lstEncrypt.Size = new System.Drawing.Size(191, 342);
            this.lstEncrypt.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(39, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(39, 89);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encriptar";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 25);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(97, 13);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Número de cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(29, 51);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(156, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.lblCedula);
            this.grbInputs.Controls.Add(this.txtCedula);
            this.grbInputs.Controls.Add(this.btnEncrypt);
            this.grbInputs.Controls.Add(this.btnExit);
            this.grbInputs.Controls.Add(this.btnReset);
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(198, 210);
            this.grbInputs.TabIndex = 8;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Ingreso de Datos";
            // 
            // grbEncrypt
            // 
            this.grbEncrypt.Controls.Add(this.lstEncrypt);
            this.grbEncrypt.Location = new System.Drawing.Point(228, 12);
            this.grbEncrypt.Name = "grbEncrypt";
            this.grbEncrypt.Size = new System.Drawing.Size(218, 376);
            this.grbEncrypt.TabIndex = 9;
            this.grbEncrypt.TabStop = false;
            this.grbEncrypt.Text = "Encriptar";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.lstProcess);
            this.grbProcess.Location = new System.Drawing.Point(465, 12);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(322, 376);
            this.grbProcess.TabIndex = 10;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // frmEncriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 433);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbEncrypt);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmEncriptar";
            this.Text = "Encriptar Cédula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbEncrypt.ResumeLayout(false);
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcess;
        private System.Windows.Forms.ListBox lstEncrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox grbEncrypt;
        private System.Windows.Forms.GroupBox grbProcess;
    }
}

