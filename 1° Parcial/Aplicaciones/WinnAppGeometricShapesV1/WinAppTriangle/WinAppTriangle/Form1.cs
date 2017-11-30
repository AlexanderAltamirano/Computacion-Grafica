using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriangle
{
    public partial class frmTriangle : Form
    {
        private float mSideA, mSideB, mSideC, mPerimeter, mArea,mS, mHeron, mAngleA;

        private PointF mP1, mP2, mP3;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        //SF -> scale factor(constante) para manejar un zoom In y un zoom Out del dibujo;
        private const float SF = 20;
        //Un objeto de tipo pluma para dibujar en el lienzo
        private Pen mPen;

        public frmTriangle()
        {
            InitializeComponent();
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
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

        private void AreaTriangle()
        {
            mS = (mSideA + mSideB + mSideC) / 2;
            mHeron = mS * (mS - mSideA) * (mS - mSideB) * (mS - mSideC);
            mArea = (float)Math.Sqrt(mHeron);
        }

        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void InitializeData()
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

        public void DrawShape()
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            CalculateVertexC();
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            SemiperimeterTriangle();
            PerimeterTriangle();
            AreaTriangle();
            PrintData();
            DrawShape();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
