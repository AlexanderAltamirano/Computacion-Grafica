using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricShapesV2
{
    class CSquare
    {
        private float mSideA, mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        //Constructor por defecto o sin parametros
        public CSquare()
        {
            mSideA = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSideA)
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

        public void InitializeData( TextBox txtSideA, TextBox txtPerimeter, 
                                    TextBox txtArea, PictureBox picCanvas)
        {

            txtSideA.Focus();
            mSideA = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PerimeterSquare()
        {

            mPerimeter = 4 * mSideA;

        }

        public void AreaSquare()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = (float)Math.Pow(mSideA, 2);

        }
        public void DrawShape(PictureBox picCanvas)
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del pic canvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Goldenrod, 3);
            //Graficar un circulo en funcion de una elipse.
            mGraph.DrawRectangle(mPen, 0, 0, mSideA*SF,mSideA*SF);
            //mGraph.DrawRectangle(mPen,0,0,mA*SF,Mb *SF);
        }
    }
}
