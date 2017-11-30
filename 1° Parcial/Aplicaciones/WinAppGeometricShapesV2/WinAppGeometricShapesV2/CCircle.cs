using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricShapesV2
{
    class CCircle
    {

        //Datos miebro - Atributos de la clase.
        private float mRadius, mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        //Constructor por defecto o sin parametros
        public CCircle()
        {
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }
        }

        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void AreaCircle()
        {
            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        public void PrintData(TextBox txtPerimeter,
                               TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtRadius,
                                    TextBox txtPerimeter,
                                    TextBox txtArea,
                                    PictureBox picCanvas)
        {
            txtRadius.Focus();//Cursor titilando en una caja de texto
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtRadius.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();
        }

        public void DrawShape(PictureBox picCanvas)
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del pic canvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            //Graficar un circulo en funcion de una elipse.
            mGraph.DrawEllipse(mPen, 0, 0, 2 * mRadius * SF, 2 * mRadius * SF);
            //mGraph.DrawRectangle(mPen,0,0,mA*SF,Mb *SF);
        }

    }
}
