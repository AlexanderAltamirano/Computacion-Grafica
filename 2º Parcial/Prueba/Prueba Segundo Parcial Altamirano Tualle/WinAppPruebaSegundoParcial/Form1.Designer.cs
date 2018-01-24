namespace WinAppPruebaSegundoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lstBinarios = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesencriptacion = new System.Windows.Forms.Button();
            this.lstDesencriptacion = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(19, 61);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(156, 20);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // lstBinarios
            // 
            this.lstBinarios.FormattingEnabled = true;
            this.lstBinarios.Location = new System.Drawing.Point(191, 43);
            this.lstBinarios.Name = "lstBinarios";
            this.lstBinarios.Size = new System.Drawing.Size(202, 212);
            this.lstBinarios.TabIndex = 4;
            this.lstBinarios.SelectedIndexChanged += new System.EventHandler(this.lstBinarios_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Encriptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstDesencriptacion);
            this.groupBox1.Controls.Add(this.btnDesencriptacion);
            this.groupBox1.Controls.Add(this.lstBinarios);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encriptación";
            // 
            // btnDesencriptacion
            // 
            this.btnDesencriptacion.Location = new System.Drawing.Point(32, 141);
            this.btnDesencriptacion.Name = "btnDesencriptacion";
            this.btnDesencriptacion.Size = new System.Drawing.Size(130, 23);
            this.btnDesencriptacion.TabIndex = 6;
            this.btnDesencriptacion.Text = "Desencriptar";
            this.btnDesencriptacion.UseVisualStyleBackColor = true;
            this.btnDesencriptacion.Click += new System.EventHandler(this.btnDesencriptacion_Click);
            // 
            // lstDesencriptacion
            // 
            this.lstDesencriptacion.FormattingEnabled = true;
            this.lstDesencriptacion.Location = new System.Drawing.Point(415, 45);
            this.lstDesencriptacion.Name = "lstDesencriptacion";
            this.lstDesencriptacion.Size = new System.Drawing.Size(202, 212);
            this.lstDesencriptacion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encriptación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desencriptación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encriptación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ListBox lstBinarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesencriptacion;
        private System.Windows.Forms.ListBox lstDesencriptacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

