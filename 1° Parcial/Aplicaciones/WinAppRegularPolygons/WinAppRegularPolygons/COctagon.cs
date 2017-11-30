using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class COctagon
    {
        // Datos miembro - Atributos. 
        private float mSide; 
        private float mPerimeter, mArea;
        private float mApothem, mSegmentB, mAngle1, mAngle2; 

        // Datos miembro que operan con el modo gráfico. 
        private Graphics mGraph; 
        private Pen mPen; 
        private const float SF = 20; 
        private PointF mA, mB, mC, mD, mE, mF, mG, mH; 
        
        // Funciones miembro - Métodos.

        // Constructor por defecto. 
        public COctagon()
        { 
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; 
        }

        // Función que permite leer el lado del Hexágono. 
        public void ReadData(TextBox txtSide) 
        {
            try
            {
                // Convetir de tipo de dato String a float con el float.Parse
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Error en la lectura de datos...",
                                "Mensaje de error");
            }
        }                

        // Función que permite calcular el perímetro del hexágono. 
        public void PerimeterHexagon() 
        {              
            mPerimeter = 8 * mSide; 
        }

        // Función que permite calcular el área del hexágono. 
        public void AreaHexagon() 
        { 
            mAngle1 = 45.0f * (float)Math.PI / 180.0f;
            mAngle2 = (mAngle1 / 2.0f) * (float)Math.PI / 180.0f;
            mApothem = mSide / (2.0f * (float)Math.Tan(mAngle2));
            mArea = mPerimeter * mApothem / 2.0f; 
        }

        // Función que permite imprimir el perímetro y el área del hexágono. 
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

            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; 

            picCanvas.Refresh();
        }
              
        // Función que permite calcular los valores de los seis vértices del hexágono, 
        // utilizando fórmulas de Geometría Analítica. 
        private void CalculateVertex() 
        {
            mSegmentB = mSide * (float)Math.Cos(mAngle1);

            mA.X = mSegmentB * SF; mA.Y = 0.0f * SF;
            mB.X = (mSegmentB + mSide) * SF; mB.Y = 0.0f * SF;
            mC.X = (2.0f * mSegmentB + mSide) * SF; mC.Y = mSegmentB * SF;
            mD.X = (2.0f * mSegmentB + mSide) * SF; mD.Y = (mSegmentB + mSide) * SF;
            mE.X = (mSegmentB + mSide) * SF; mE.Y = (2.0f * mSegmentB + mSide) * SF;
            mF.X = mSegmentB * SF; mF.Y = (2.0f * mSegmentB + mSide) * SF;
            mG.X = 0.0f * SF; mG.Y = (mSegmentB + mSide) * SF;
            mH.X = 0.0f * SF; mH.Y = mSegmentB * SF;
        }

        // Función que permite graficar un hexágono en base a los valores de los seis
        // vértices representados por seis puntos en un plano. 
        public void GraphShape(PictureBox picCanvas) 
        { 
            mGraph = picCanvas.CreateGraphics(); 
            mPen = new Pen(Color.Blue, 3);

            CalculateVertex();

            //mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
            mGraph.DrawLine(mPen, mA, mB);
            mGraph.DrawLine(mPen, mA, mH);
            mGraph.DrawLine(mPen, mB, mC);
            mGraph.DrawLine(mPen, mH, mG);
            mGraph.DrawLine(mPen, mC, mD);
            mGraph.DrawLine(mPen, mG, mF);
            mGraph.DrawLine(mPen, mD, mE);
            mGraph.DrawLine(mPen, mF, mE);
        }

    }
}
