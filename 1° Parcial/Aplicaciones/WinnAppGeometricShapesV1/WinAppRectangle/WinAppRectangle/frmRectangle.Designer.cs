using System;

namespace WinAppRectangle
{
    partial class frmRectangle
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtSideHeight = new System.Windows.Forms.TextBox();
            this.txtSideWidth = new System.Windows.Forms.TextBox();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtSideHeight);
            this.grbInputs.Controls.Add(this.txtSideWidth);
            this.grbInputs.Controls.Add(this.lblSideB);
            this.grbInputs.Controls.Add(this.lblSideA);
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(343, 83);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            // 
            // txtSideHeight
            // 
            this.txtSideHeight.Location = new System.Drawing.Point(226, 48);
            this.txtSideHeight.Name = "txtSideHeight";
            this.txtSideHeight.Size = new System.Drawing.Size(100, 20);
            this.txtSideHeight.TabIndex = 4;
            // 
            // txtSideWidth
            // 
            this.txtSideWidth.Location = new System.Drawing.Point(226, 13);
            this.txtSideWidth.Name = "txtSideWidth";
            this.txtSideWidth.Size = new System.Drawing.Size(100, 20);
            this.txtSideWidth.TabIndex = 3;
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(6, 16);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(157, 13);
            this.lblSideB.TabIndex = 1;
            this.lblSideB.Text = "Ingrese un valor para el ancho :";
            this.lblSideB.Click += new System.EventHandler(this.lblSideB_Click);
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(6, 51);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(153, 13);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Ingrese un valor para la altura :";
            this.lblSideA.Click += new System.EventHandler(this.lblSideA_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(12, 101);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(343, 65);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(131, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Location = new System.Drawing.Point(12, 172);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(343, 87);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(183, 51);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(183, 19);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(26, 51);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area :";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(24, 22);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(57, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro :";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(361, 12);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(371, 247);
            this.grbCanvas.TabIndex = 3;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 16);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(300, 200);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(744, 284);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmRectangle";
            this.Text = "Rectangulo";
            this.Load += new System.EventHandler(this.frmRectangle_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtSideWidth;
        private System.Windows.Forms.TextBox txtSideHeight;
    }
}

