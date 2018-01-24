using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppLimasonSinLaso
{
    class CLimasonsinLazo
    {
        private float mA,mB;
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 20;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        private PointF[] mP = new PointF[361];
        // Valores de 'x' y de 'y'.
        private float mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función.
        private float I1, I2;

        public CLimasonsinLazo() {
            mA = 0.0f; mB = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        public void InitializeData()
        {
            mA = 0.0f; mB = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        public void ReadData(TextBox txtA,TextBox txtB)
        {
            mA = float.Parse(txtA.Text);
            mB = float.Parse(txtB.Text);
        }

        public void Analice(TextBox txtAnalice) {
            if (mA == mB)
            {
                txtAnalice.Text = "La gráfica es una Cardioide";
            }
            else if (mA > 0)
            {
                txtAnalice.Text = "La gráfica es un Limasón sin un lazo";
            }
            else if(mA < mB) {
                txtAnalice.Text = "La gráfica es un Limasón con un lazo";
            }

        }

        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Black);
            // Eje horizontal.
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            // Eje vertical.
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
        }

        public void EvaluateFunction(ListBox lstX, ListBox lstY,
                                     ListBox lstXp, ListBox lstYp)
        {
            float r; // Radio de la función polar.
            float i; // Contador para controlar la función.
            int j;   // Contador para controlar el arreglo de puntos.
            I1 = 0.0f; I2 = 2 * (float)Math.PI;
            for (i = I1, j = 0; i <= I2; i += (float)Math.PI / 180, j++)
            {
                // Tabla de valores del mundo real.
                r = mA + mB * (float)Math.Cos(i);
                mX = r * (float)Math.Cos(i); lstX.Items.Add(mX.ToString());
                mY = r * (float)Math.Sin(i); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }

        public void DrawCurve(PictureBox picCanvas, ListBox lstX,
                              ListBox lstY, ListBox lstXp, ListBox lstYp)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Tomato);
            mP = new PointF[361];

            EvaluateFunction(lstX, lstY, lstXp, lstYp);

            mGraph.DrawCurve(ObjPen, mP);
        }

        public void InitializeControls(TextBox txtA,TextBox txtB, PictureBox picCanvas,
                                       ListBox lstX, ListBox lstY,
                                       ListBox lstXp, ListBox lstYp)
        {
            txtA.Text = ""; txtB.Text = ""; picCanvas.Refresh();
            lstX.Items.Clear(); lstY.Items.Clear();
            lstXp.Items.Clear(); lstYp.Items.Clear();
        }

    }
}
