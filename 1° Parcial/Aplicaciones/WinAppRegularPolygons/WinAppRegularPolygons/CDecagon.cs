using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CDecagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle, mAngle1;
        private float mApothem, mA, mB, mC, mD, mE, mF;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7, mP8, mP9, mP10, mP11, mP12;
        public CDecagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f;
           
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del heptágono.
        public void ReadData(TextBox txtSide)
        {
            mL = float.Parse(txtSide.Text);
        }
        // Función que permite calcular el perímetro del heptágono.
        public void PerimeterHeptagon()
        {
            mPerimeter = 10* mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemHeptagon()
        {
            mAngle = 72f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = (mL * (float)Math.Tan(mAngle)) / 2;
        }
        // Función que permite calcular el área del heptágono.
        public void AreaHeptagon()
        {
            ApothemHeptagon();
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del heptágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del hexágono.
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSide.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            // Mantiene el cursor titilando en una caja de texto.
            txtSide.Focus();

            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            picCanvas.Refresh();

            mPen = new Pen(Color.Teal, 3);

            mAngle = 18f;
             mAngle = ConvertGradesToRadians(mAngle);
             mA = mL * (float)Math.Cos(mAngle);

             mAngle = 54f;
             mAngle = ConvertGradesToRadians(mAngle);
             mB = mL * (float)Math.Cos(mAngle);

             mAngle = 18f;
             mAngle = ConvertGradesToRadians(mAngle);
             mC = mL * (float)Math.Sin(mAngle);

             mAngle = 54f;
             mAngle = ConvertGradesToRadians(mAngle);
             mD = mL * (float)Math.Sin(mAngle);



             mP1.X = mB; mP1.Y = mC; mP2.X = mA+mB; mP2.Y = 0;
             mP10.X = 0; mP10.Y = mC + mD;
             mP3.X = (2 * mA) + mB; mP3.Y = mC; mP4.X = 2*mA+ 2*mB; mP4.Y = mC + mD;
             mP5.X = 2*mB+2*mA; mP5.Y = mC+mL+mD; mP9.X = 0; mP9.Y = mC + mD + mL; mP6.X =  mB + 2 * mA; mP6.Y = mC + mL + 2*mD; mP7.X = mA+mB; mP7.Y = 2*mC+2*mD+mL;
             mP8.X = mB; mP8.Y = mC+ 2* mD+mL; 

              mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
              mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP10.X * SF, mP10.Y * SF);
              mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
              mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
              mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
              mGraph.DrawLine(mPen, mP10.X * SF, mP10.Y * SF, mP9.X * SF, mP9.Y * SF);
              mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP6.X * SF, mP6.Y * SF);
              mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP7.X * SF, mP7.Y * SF);

              mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP8.X * SF, mP8.Y * SF);

              mGraph.DrawLine(mPen, mP8.X * SF, mP8.Y * SF, mP9.X * SF, mP9.Y * SF);
        }
    }
}

