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
        private float mX;
        private float mY;

        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        // Funcion dual - puede recibir valores y retornar valores.
        public float MX
        {
            get 
            {
                return mX; 
            }
            set
            { 
                mX = value; 
            }
        }
        // Funcion dual - puede recibir valores y retornar valores.
        public float MY
        {
            get
            { 
                return mY; 
            }
            set 
            {
                mY = value; 
            }
        }
        //Constructores por defecto - con parametros

        public CVector2D()
        {
            mX = 0.0f;
            mY = 0.0f;
        }
        public CVector2D(float x, float y)
        {
            mX = x; mY =y;
        }

        //Funcion de lectura de datos.

        public void ReadData(NumericUpDown nudXVector , NumericUpDown nudYVector)
        {
            mX = (float)(nudXVector.Value);
            mY = (float)(nudYVector.Value);
        }

        //Funcion de impresión de datos

        public void PrintData(TextBox txtXVector, TextBox txtYVector)
        {
            txtXVector.Text = mX.ToString();
            txtYVector.Text = mY.ToString();
        }

        //Funcion para sumar ds vectores
        public CVector2D Addition(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mX = U.mX + V.mX;
            Temp.mY = U.mY + V.mY;

            return (Temp);
        }
      
        public CVector2D Addition(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mX = mX + V.mX;
            Temp.mY = mY + V.mY;

            return (Temp);
        }
        //Funcion para restar ds vectores
        public CVector2D Sustraction(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mX = U.mX - V.mX;
            Temp.mY = U.mY - V.mY;

            return (Temp);
        }

        public CVector2D Sustraction(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mX = mX - V.mX;
            Temp.mY = mY - V.mY;

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
            return new PointF((float)(V.mX *SF+200), (-1)*(float)V.mY *SF+150);
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
    }
}
