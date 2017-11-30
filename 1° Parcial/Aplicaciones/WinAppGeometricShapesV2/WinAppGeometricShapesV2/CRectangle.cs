using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricShapesV2
{
    class CRectangle
    {
        private float mSideWidth, mSideHeight, mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        //Constructor por defecto o sin parametros
        public CRectangle()
        {
            mSideWidth = 0.0f; mSideHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSideA, TextBox txtSideB)
        {
            try
            {
                mSideHeight  = float.Parse(txtSideA.Text);
                mSideWidth = float.Parse(txtSideB.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        public void InitializeData( TextBox txtSideHeight, TextBox txtSideWidth, TextBox txtPerimeter,
                                    TextBox txtArea, PictureBox picCanvas)
        {

            txtSideWidth.Focus();
            mSideWidth = 0.0f; mSideHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideWidth.Text = ""; txtSideHeight.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PerimeterRectangle()
        {

            mPerimeter = (2 * mSideWidth) + (2* mSideHeight);

        }

        public void AreaRectangle()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = mSideHeight*mSideWidth;
        }
        public void DrawShape(PictureBox picCanvas)
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del pic canvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Coral, 3);
            //Graficar un circulo en funcion de una elipse.
            mGraph.DrawRectangle(mPen, 0, 0, mSideWidth * SF, mSideHeight * SF);
            //mGraph.DrawRectangle(mPen,0,0,mA*SF,Mb *SF);
        }
    }
}

