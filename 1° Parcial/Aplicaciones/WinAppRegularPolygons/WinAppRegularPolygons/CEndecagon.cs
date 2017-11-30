using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CEndecagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mApothem, mA, mB, mC, mD, mE, mF, mG, mH, mI, mJ, mK;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7, mP8, mP9, mP10, mP11, mP12;
        public CEndecagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f;

            mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f; mE = 0.0f; mF = 0.0f; mG = 0.0f;
            mH = 0.0f; mI = 0.0f; mJ = 0.0f; mK = 0.0f;

            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del Endecágono.
        public void ReadData(TextBox txtSide)
        {
            mL = float.Parse(txtSide.Text);
        }
        // Función que permite calcular el perímetro del Endecágono.
        public void PerimeterEndecagon()
        {
            mPerimeter = 11 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemEndecagon()
        {
            mAngle = 16.3636f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / (2 * (float)Math.Tan(mAngle));
        }
        // Función que permite calcular el área del Endecágono.
        public void AreaEndecagon()
        {
            ApothemEndecagon();
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del Endecágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }
        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del Endecágono.
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSide.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            // Mantiene el cursor titilando en una caja de texto.
            txtSide.Focus();

            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f;
            mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f; mE = 0.0f; mF = 0.0f; mG = 0.0f;
            mH = 0.0f; mI = 0.0f; mJ = 0.0f; mK = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            picCanvas.Refresh();

            mPen = new Pen(Color.Teal, 3);

            mAngle = 24.5456f;
            mAngle = ConvertGradesToRadians(mAngle);
            mA = mL * (float)Math.Sin(mAngle);

            mAngle = 32.7272f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Cos(mAngle);

            mAngle = 81.8181f;
            mAngle = ConvertGradesToRadians(mAngle);
            mC = mL * (float)Math.Cos(mAngle);

            mAngle = 49.0909f;
            mAngle = ConvertGradesToRadians(mAngle);
            mD = mL * (float)Math.Cos(mAngle);

            mAngle = 32.7272f;
            mAngle = ConvertGradesToRadians(mAngle);
            mE = mL * (float)Math.Sin(mAngle);

            mAngle = 24.5456f;
            mAngle = ConvertGradesToRadians(mAngle);
            mF = mL * (float)Math.Cos(mAngle);

            mAngle = 81.8181f;
            mAngle = ConvertGradesToRadians(mAngle);
            mG = mL * (float)Math.Sin(mAngle);

            mAngle = 49.0909f;
            mAngle = ConvertGradesToRadians(mAngle);
            mH = mL * (float)Math.Sin(mAngle);

            mAngle = 16.3636f;
            mAngle = ConvertGradesToRadians(mAngle);
            mI = mL * (float)Math.Sin(mAngle);

            mAngle = 16.3636f;
            mAngle = ConvertGradesToRadians(mAngle);
            mJ = mL * (float)Math.Cos(mAngle);


            mP1.X = mA + mB; mP1.Y = 0;
            mP2.X = mA + mB + mL; mP2.Y = 0;
            mP3.X = (2 * mB) + mA + mL; mP3.Y = mE;
            mP4.X = 2 * mA + 2 * mB + mL ; mP4.Y = mE+ mF;
            mP5.X = 2 * mA + 2 * mB + mL - mC; mP5.Y = mE + mF + mG;
            mP6.X = mC + mD + (mJ * 2); mP6.Y = mE + mF + mG + mH;
            mP7.X = mC + mD + mJ; mP7.Y = mE + mF + mG + mH +mI;
            mP8.X = mC + mD; mP8.Y = mE + mF + mG + mH;
            mP9.X = mC; mP9.Y = mE + mF + mG;
            mP10.X = 0; mP10.Y = mE + mF;
            mP11.X = mA; mP11.Y = mE;





            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP6.X * SF, mP6.Y * SF);
            mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP7.X * SF, mP7.Y * SF);
            mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP8.X * SF, mP8.Y * SF);
            mGraph.DrawLine(mPen, mP8.X * SF, mP8.Y * SF, mP9.X * SF, mP9.Y * SF);
            mGraph.DrawLine(mPen, mP9.X * SF, mP9.Y * SF, mP10.X * SF, mP10.Y * SF);
            mGraph.DrawLine(mPen, mP10.X * SF, mP10.Y * SF, mP11.X * SF, mP11.Y * SF);
            mGraph.DrawLine(mPen, mP11.X * SF, mP11.Y * SF, mP1.X * SF, mP1.Y * SF);

        }
    }
}
