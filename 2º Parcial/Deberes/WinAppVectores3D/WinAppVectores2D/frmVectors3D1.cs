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

        private CVector3D A = new CVector3D();
        private CVector3D B = new CVector3D();
        private CVector3D R = new CVector3D();

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
            A.ReadData(nudXVectorA, nudYVectorA, nudZVectorA);
            B.ReadData(nudXVectorB, nudYVectorB, nudZVectorB);

            R = R.Addition(A, B);

            //R = A.Addition(B);
            //R = B.Addition(A);

            R.PrintData(txtXVectorR,txtYVectorR, txtZVectorR);
            R.GraphAxis(picCanvas);
            A.MZ = A.MZ * (-1);
            B.MZ = B.MZ * (-1);
            R.MZ = R.MZ * (-1);
            A.Graficadora(A, picCanvas, Color.Red);            
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);

        }

        private void btnSustraction_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA, nudZVectorA);
            B.ReadData(nudXVectorB, nudYVectorB, nudZVectorB);

            R = R.Sustraction(A, B);
            // R = A.Sustraction(B);
         
            R.PrintData(txtXVectorR, txtYVectorR, txtZVectorR);
            R.GraphAxis(picCanvas);
            A.MZ = A.MZ * (-1);
            B.MZ = B.MZ * (-1);
            R.MZ = R.MZ * (-1);
            A.Graficadora(A, picCanvas, Color.Red);           
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);

        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA, nudZVectorA);
            B.ReadData(nudXVectorB, nudYVectorB, nudZVectorB);

            R = R.ProdcutoPunto(A, B);
            //R = A.ProdcutoPunto(B);

            R.PrintData(txtXVectorR, txtYVectorR, txtZVectorR);
            R.GraphAxis(picCanvas);
            A.MZ = A.MZ * (-1);
            B.MZ = B.MZ * (-1);
            R.MZ = R.MZ * (-1);
            A.Graficadora(A, picCanvas, Color.Red);
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA, nudZVectorA);
            B.ReadData(nudXVectorB, nudYVectorB, nudZVectorB);

            R = R.ProductoCruz(A, B);
            //R = A.ProductoCruz(B);

            R.PrintData(txtXVectorR, txtYVectorR, txtZVectorR);
            R.GraphAxis(picCanvas);
            A.Graficadora(A, picCanvas, Color.Red);
            A.MZ = A.MZ * (-1);
            B.MZ = B.MZ * (-1);
            R.MZ = R.MZ * (-1);
            B.Graficadora(B, picCanvas, Color.Blue);
            R.Graficadora(R, picCanvas, Color.Green);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblImaginario_Click(object sender, EventArgs e)
        {

        }
    }
}
