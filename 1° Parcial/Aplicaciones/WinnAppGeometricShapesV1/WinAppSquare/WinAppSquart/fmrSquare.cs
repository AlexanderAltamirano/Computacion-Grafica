using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSquart
{
    public partial class fmrSquare : Form
    {

        private float mSideA, mSideB, mPerimeter, mArea;
        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        public fmrSquare()
        {
            InitializeComponent();
            mSideA = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void InitializeData()
        {

            txtSideA.Focus();
            mSideA = 0.0f; mSideB = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();
        }

        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void PerimeterSquart()
        {

            mPerimeter = 4*mSideA;

        }

        private void AreaSquart()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = (float)Math.Pow(mSideA,2);

        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSideA_Click(object sender, EventArgs e)
        {

        }

        private void fmrSquart_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterSquart();
            AreaSquart();
            PrintData();
            DrawShape();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void DrawShape()
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del pic canvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Goldenrod, 3);
            //Graficar un circulo en funcion de una elipse.
            mGraph.DrawRectangle(mPen, 0, 0, mSideA * SF, mSideA * SF);
            //mGraph.DrawRectangle(mPen,0,0,mA*SF,Mb *SF);
        }
    }
}
