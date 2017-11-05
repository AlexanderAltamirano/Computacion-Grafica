﻿namespace WinAppSquart
{
    partial class fmrSquart
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblSideA = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.grbInput.SuspendLayout();
            this.grbButton.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.lblSideA);
            this.grbInput.Controls.Add(this.txtSideA);
            this.grbInput.Location = new System.Drawing.Point(26, 25);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(378, 100);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(39, 46);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(74, 13);
            this.lblSideA.TabIndex = 1;
            this.lblSideA.Text = "Ingresar valor:";
            this.lblSideA.Click += new System.EventHandler(this.lblSideA_Click);
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(192, 43);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);
            this.txtSideA.TabIndex = 0;
            this.txtSideA.TextChanged += new System.EventHandler(this.txtSideA_TextChanged);
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.btnExit);
            this.grbButton.Controls.Add(this.btnReset);
            this.grbButton.Controls.Add(this.btnCalculate);
            this.grbButton.Location = new System.Drawing.Point(26, 141);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(378, 100);
            this.grbButton.TabIndex = 1;
            this.grbButton.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(143, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(42, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lblArea);
            this.grbOutput.Controls.Add(this.lblPerimeter);
            this.grbOutput.Controls.Add(this.txtArea);
            this.grbOutput.Controls.Add(this.txtPerimeter);
            this.grbOutput.Location = new System.Drawing.Point(26, 257);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(378, 100);
            this.grbOutput.TabIndex = 2;
            this.grbOutput.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(42, 65);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area : ";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(42, 25);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(57, 13);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perimeter :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(192, 62);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 1;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(192, 22);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 0;
            // 
            // fmrSquart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 392);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.grbInput);
            this.Name = "fmrSquart";
            this.Text = "Cuadrado";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbButton.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
    }
}

