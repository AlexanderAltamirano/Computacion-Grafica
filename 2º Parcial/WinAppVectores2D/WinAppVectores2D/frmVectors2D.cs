using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVectores2D
{
    public partial class frmVectors2D : Form
    {

        //Datos Miembro (Composicion Simple)

        private CVector2D A = new CVector2D();
        private CVector2D B = new CVector2D();
        private CVector2D R = new CVector2D();

        public frmVectors2D()
        {
            InitializeComponent();
            R.GraphAxis(picCanvas);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdition_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);

           // R = R.Addition(A, B);
            R = A.Addition(B);
            R = B.Addition(A);

            R.PrintData(txtXVectorR,txtYVectorR);
            R.GraphAxis(picCanvas);
            A.Graficadora(A, picCanvas, Color.Red);
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);
            R.Graficadora(B, R, picCanvas, Color.BlueViolet);
            R.Graficadora(A, R, picCanvas, Color.BlueViolet);
        }

        private void btnSustraction_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);

            // R = R.Sustraction(A, B);
            R = A.Sustraction(B);
         
            R.PrintData(txtXVectorR, txtYVectorR);
            R.GraphAxis(picCanvas);
            A.Graficadora(A, picCanvas, Color.Red);
            B.MX = B.MX * (-1);
            B.MY = B.MY * (-1);
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);
            R.Graficadora(B, R, picCanvas, Color.BlueViolet);
            R.Graficadora(A, R, picCanvas, Color.BlueViolet);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVectors2D_Load(object sender, EventArgs e)
        {

        }

        private void btnGraf_Click(object sender, EventArgs e)
        {

        }
    }
}
