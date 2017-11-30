using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CEneagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle, mAngle1;
        private float mApothem, mA, mB, mC, mD, mE, mF, mG, mH;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7, mP8, mP9, mP10, mP11, mP12;
        public CEneagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f;
            mC = 0.0f; mD = 0.0f; mE = 0.0f; mF = 0.0f; mG = 0.0f;

            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del Eneágono.
        public void ReadData(TextBox txtSide)
        {
            mL = float.Parse(txtSide.Text);
        }
        // Función que permite calcular el perímetro del Eneágono.
        public void PerimeterEneagon()
        {
            mPerimeter = 9 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemEneagon()
        {
            mAngle = 20.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / 2 / (float)Math.Tan(mAngle);
        }
        // Función que permite calcular el área del Eneágono.
        public void AreaEneagon()
        {
            ApothemEneagon();
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del Eneágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString(); 
            txtPerimeter.Text = mPerimeter.ToString();
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
            mE = 0.0f; mF = 0.0f; mG = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            picCanvas.Refresh();

            mPen = new Pen(Color.Teal, 3);

            mAngle = 40f;
            mAngle = ConvertGradesToRadians(mAngle);
            mA = mL * (float)Math.Cos(mAngle);

            mAngle = 40f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Sin(mAngle);

            mAngle = 10f;
            mAngle = ConvertGradesToRadians(mAngle);
            mC = mL * (float)Math.Cos(mAngle);

            mAngle = 10f;
            mAngle = ConvertGradesToRadians(mAngle);
            mD = mL * (float)Math.Sin(mAngle);

            mAngle = 30f;
            mAngle = ConvertGradesToRadians(mAngle);
            mG = mL * (float)Math.Cos(mAngle);

            mAngle = 20f;
            mAngle = ConvertGradesToRadians(mAngle);
            mE = mL * (float)Math.Cos(mAngle);

            mAngle = 20f;
            mAngle = ConvertGradesToRadians(mAngle);
            mH = mL * (float)Math.Sin(mAngle);

            mF = mA + mD+(mL / 2) - mE;



            mP1.X = mA + mD; mP1.Y = 0;
            mP2.X = mA + mD + mL; mP2.Y = 0;
            mP3.X = (2 * mA) + mD + mL; mP3.Y = mB;
            mP4.X = 2 * mA + 2 * mD +mL; mP4.Y = mB + mC;
            mP5.X = mA + mD + mE + (mL/2); mP5.Y = mB + mC +mG;
            mP6.X = mA + mD + (mL / 2); mP6.Y = mB + mC + mG + mH;
            mP7.X = mF; mP7.Y = mB + mC + mG;
            mP8.X = 0; mP8.Y = mB + mC;
            mP9.X = mD; mP9.Y = mB;

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
            
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP6.X * SF, mP6.Y * SF);
            
            mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP7.X * SF, mP7.Y * SF);
            
            mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP8.X * SF, mP8.Y * SF);
            
            mGraph.DrawLine(mPen, mP8.X * SF, mP8.Y * SF, mP9.X * SF, mP9.Y * SF);
            mGraph.DrawLine(mPen, mP9.X * SF, mP9.Y * SF, mP1.X * SF, mP1.Y * SF);
            
        }
    }
}
