using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricShapesV2
{
    class CTriangle
    {
        private float mSideA, mSideB, mSideC, mPerimeter, mArea, mS, mHeron,mAngleA;

        private PointF mP1, mP2, mP3;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {

            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

            if (((mSideA + mSideB) > mSideC) && ((mSideA + mSideC) > mSideB) && ((mSideB + mSideC) > mSideA))
            {
            }
            else
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        public float SemiperimeterTriangle()
        {
            return ((mSideA + mSideB + mSideC) / 2);
        }

        public void PerimeterTriangle()
        {
            float s = SemiperimeterTriangle();
            mPerimeter = 2 * s;
        }

        public void AreaTriangle()
        {
            mS = (mSideA + mSideB + mSideC) / 2;
            mHeron = mS * (mS - mSideA) * (mS - mSideB) * (mS - mSideC);
            mArea = (float)Math.Sqrt(mHeron);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {

            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();

        }

        public void InitializeData( TextBox txtSideA, TextBox txtSideB,
                                    TextBox txtSideC, TextBox txtPerimeter,
                                    TextBox txtArea, PictureBox picCanvas)
        {

            txtSideA.Focus();
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtSideB.Text = ""; txtSideC.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            picCanvas.Refresh();
        }

        private void CalculateAngleA()
        {
            mAngleA = (float)Math.Acos((mSideB * mSideB + mSideC * mSideC - mSideA * mSideA) / (2 * mSideB * mSideC));
        }

        private void CalculateVertexC()
        {
            mP1.X = 0.0f; mP1.Y = 0.0f; mP2.X = mSideC; mP2.Y = 0.0f;
            CalculateAngleA();
            mP3.X = mSideB * (float)Math.Cos(mAngleA); mP3.Y = mSideB * (float)Math.Sin(mAngleA);
        }

        public void DrawShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            CalculateVertexC();
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
        }
    }

}
