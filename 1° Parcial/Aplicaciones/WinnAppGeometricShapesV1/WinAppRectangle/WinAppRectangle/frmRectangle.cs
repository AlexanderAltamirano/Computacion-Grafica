using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRectangle
{
    public partial class frmRectangle : Form
    {
        private float mSideHeight, mSideWidth, mPerimeter, mArea;
        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        public frmRectangle()
        {
            InitializeComponent();
            mSideHeight = 0.0f; mSideWidth = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
        {

            try
            {
                mSideHeight = float.Parse(txtSideHeight.Text);
                mSideWidth = float.Parse(txtSideWidth.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void PerimeterRetangle()
        {
            mPerimeter = 2* mSideHeight + 2* mSideWidth;
        }

        private void AreaRetangle()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = mSideHeight * mSideWidth;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSideHeight.Focus();
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterRetangle();
            AreaRetangle();
            PrintData();
            DrawShape();
        }

        private void lblSideA_Click(object sender, EventArgs e)
        {

        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSideB_Click(object sender, EventArgs e)
        {

        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void PrintData()
        {

            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();

        }

        private void InitializeData()
        {

            txtSideHeight.Focus();
            mSideHeight = 0.0f; mSideWidth = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideHeight.Text = ""; txtSideWidth.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();

        }

        private void DrawShape()
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del pic canvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            //Graficar un circulo en funcion de una elipse.
            mGraph.DrawRectangle(mPen, 0, 0, mSideWidth * SF, mSideHeight * SF);
            //mGraph.DrawRectangle(mPen,0,0,mA*SF,Mb *SF);
        }
    }
}
