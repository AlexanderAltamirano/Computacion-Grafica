using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WinAppVectores2D
{
    class CVector2D
    {
        //Atributos Miembro Atributos
        //Funciones miembro - Métodos

        //Propiedades - Descriptores de acceso (set y get).
        private float mReal;
        private float mImaginario;

        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        // Funcion dual - puede recibir valores y retornar valores.
        public float MReal
        {
            get 
            {
                return mReal; 
            }
            set
            {
                mReal = value; 
            }
        }
        // Funcion dual - puede recibir valores y retornar valores.
        public float MImaginario
        {
            get
            { 
                return mImaginario; 
            }
            set 
            {
                mImaginario = value; 
            }
        }
        //Constructores por defecto - con parametros

        public CVector2D()
        {
            mReal = 0.0f;
            mImaginario = 0.0f;
        }
        public CVector2D(float x, float y)
        {
            mReal = x; mImaginario = y;
        }

        //Funcion de lectura de datos.

        public void ReadData(NumericUpDown nudXVector , NumericUpDown nudYVector)
        {
            mReal = (float)(nudXVector.Value);
            mImaginario = (float)(nudYVector.Value);
        }

        //Funcion de impresión de datos

        public void PrintData(TextBox txtXVector, TextBox txtYVector)
        {
            txtXVector.Text = mReal.ToString();
            txtYVector.Text = mImaginario.ToString();
        }

        //Funcion para sumar ds vectores
        public CVector2D Addition(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mReal = U.mReal + V.mReal;
            Temp.mImaginario = U.mImaginario + V.mImaginario;

            return (Temp);
        }
      
        public CVector2D Addition(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mReal = mReal + V.mReal;
            Temp.mImaginario = mImaginario + V.mImaginario;

            return (Temp);
        }
        //Funcion para restar ds vectores
        public CVector2D Sustraction(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mReal = U.mReal - V.mReal;
            Temp.mImaginario = U.mImaginario - V.mImaginario;

            return (Temp);
        }

        public CVector2D Sustraction(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mReal = mReal - V.mReal;
            Temp.mImaginario = mImaginario - V.mImaginario;

            return (Temp);
        }

        public CVector2D Multiplication(CVector2D V)
        {
            CVector2D Temp = new CVector2D();
            // mx my
            // v.mx v.my
            Temp.mReal = (MReal * V.MReal) - (mImaginario * V.mImaginario);
            Temp.mImaginario = (MReal * V.mImaginario) + (V.MReal * mImaginario);

            return (Temp);
        }

        public CVector2D Division(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mReal = ((MReal*V.MReal)+(MImaginario*V.MImaginario))/((V.MReal * V.MReal) + (V.mImaginario * V.mImaginario));
            Temp.mImaginario = ((mImaginario*V.MReal)-(MReal*V.mImaginario))/((V.MReal*V.MReal)+(V.mImaginario*V.mImaginario));

            return (Temp);
        }

        public void GraphAxis(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);

            //Dibujar el eje Horizontal
            mGraph.DrawLine(mPen,0,150,400,150);

            //Dibujar el eje vertical

            mGraph.DrawLine(mPen, 200, 0, 200, 300);
        }
        public PointF VectorPointF(CVector2D V)
        {
            return new PointF((float)(V.mReal * SF+200), (-1)*(float)V.mImaginario * SF+150);
        }
        public void  Graficadora(CVector2D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();
            
            PointF origin = VectorPointF(new CVector2D(0, 0));
            PointF end = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color),2), origin, end);
        }
        public void Graficadora(CVector2D U, CVector2D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();

            PointF origin = VectorPointF(U);
            PointF end = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
        }
        public void GraficadoraMultiplicacion(CVector2D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();

            PointF origin = VectorPointF(new CVector2D(0, 0));
            PointF end = VectorPointF(V);

            PointF origin1 = VectorPointF(new CVector2D(0, 0));
            PointF end1 = VectorPointF(new CVector2D(V.MReal, 0));

            PointF origin2 = VectorPointF(new CVector2D(V.MReal, 0));
            PointF end2 = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin1, end1);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin2, end2);
        }
    }
}
