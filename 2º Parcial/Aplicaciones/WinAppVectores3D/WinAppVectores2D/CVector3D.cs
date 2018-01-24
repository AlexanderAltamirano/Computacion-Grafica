using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WinAppVectores2D
{
    class CVector3D
    {
        //Atributos Miembro Atributos
        //Funciones miembro - Métodos

        //Propiedades - Descriptores de acceso (set y get).
        private float mX;
        private float mY;
        private float mZ;

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

        public float MZ
        {
            get
            {
                return mZ;
            }
            set
            {
                mZ = value;
            }
        }
        //Constructores por defecto - con parametros

        public CVector3D()
        {
            mX = 0.0f;
            mY = 0.0f;
            mZ = 0.0f;
        }
        public CVector3D(float x, float y, float z)
        {
            mX = x; mY = y; mZ = z;
        }

        //Funcion de lectura de datos.

        public void ReadData(NumericUpDown nudXVector , NumericUpDown nudYVector, NumericUpDown nudZVector)
        {
            mX = (float)(nudXVector.Value);
            mY = (float)(nudYVector.Value);
            mZ = (float)(nudZVector.Value);
        }

        //Funcion de impresión de datos

        public void PrintData(TextBox txtXVector, TextBox txtYVector, TextBox txtZVector)
        {
            txtXVector.Text = mX.ToString();
            txtYVector.Text = mY.ToString();
            txtZVector.Text = mZ.ToString();
        }

        //Funcion para sumar ds vectores
        public CVector3D Addition(CVector3D U, CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = U.mX + V.mX;
            Temp.mY = U.mY + V.mY;
            Temp.mZ = U.mZ + V.mZ;

            return (Temp);
        }
      
        public CVector3D Addition(CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = mX + V.mX;
            Temp.mY = mY + V.mY;
            Temp.mZ = mZ + V.mZ;

            return (Temp);
        }
        //Funcion para restar ds vectores
        public CVector3D Sustraction(CVector3D U, CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = U.mX - V.mX;
            Temp.mY = U.mY - V.mY;
            Temp.mZ = U.mZ - V.mZ;

            return (Temp);
        }

        public CVector3D Sustraction(CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = mX - V.mX;
            Temp.mY = mY - V.mY;
            Temp.mZ = mZ - V.mZ;

            return (Temp);
        }

        public CVector3D ProdcutoPunto(CVector3D U, CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = U.mX * V.mX;
            Temp.mY = U.mY * V.mY;
            Temp.mZ = U.mZ * V.mZ;

            return (Temp);
        }

        public CVector3D ProductoCruz(CVector3D U, CVector3D V)
        {
            CVector3D Temp = new CVector3D();

            Temp.mX = (U.mY * V.mZ) - (U.mZ * V.mY);
            Temp.mY = (-1) * ((U.mX * V.mZ) - (U.mZ * V.mX));
            Temp.mZ = (U.mX * V.mY) - (U.mY * V.mX);

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

            //Dibujar el eje Z

            mGraph.DrawLine(mPen, 0, 300, 400, 0);
        }
        public PointF VectorPointF(CVector3D V)
        {
            float tempX = V.mX + ((V.mZ * 4) / 5);
            float tempY = V.mY + ((V.mZ * 3) / 5);
            return new PointF((float)(tempX * SF+200), (-1)*(float)(tempY) * SF+150);
        }

        public void  Graficadora(CVector3D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();
            
            PointF origin = VectorPointF(new CVector3D(0, 0, 0));
            PointF end = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color),2), origin, end);

            //Linea guia1
            PointF origin1 = VectorPointF(new CVector3D(V.mX, 0, 0));
            PointF end1 = VectorPointF(new CVector3D(V.mX, V.mY, 0));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin1, end1);

            //Linea guia2
            PointF origin2 = VectorPointF(new CVector3D(0, V.mY, 0));
            PointF end2 = VectorPointF(new CVector3D(V.mX, V.mY, 0));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin2, end2);

            //Linea guia3
            PointF origin3 = VectorPointF(new CVector3D(V.mX, 0, 0));
            PointF end3 = VectorPointF(new CVector3D(V.mX, 0, V.mZ));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin3, end3);

            //Linea guia4
            PointF origin4 = VectorPointF(new CVector3D(0, V.mY, 0));
            PointF end4 = VectorPointF(new CVector3D(0, V.mY, V.mZ));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin4, end4);

            //Linea guia5
            PointF origin5 = VectorPointF(new CVector3D(0, V.mY, V.mZ));
            PointF end5 = VectorPointF(V);
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin5, end5);

            //Linea guia6
            PointF origin6 = VectorPointF(new CVector3D(V.mX, 0, V.mZ));
            PointF end6 = VectorPointF(V);
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin6, end6);

            //Linea guia7
            PointF origin7 = VectorPointF(new CVector3D(V.mX, V.mY, 0));
            PointF end7 = VectorPointF(V);
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin7, end7);

            //Linea guia8
            PointF origin8 = VectorPointF(new CVector3D(0, 0, V.mZ));
            PointF end8 = VectorPointF(new CVector3D(V.mX, 0, V.mZ));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin8, end8);

            //Linea guia9
            PointF origin9 = VectorPointF(new CVector3D(0, 0, V.mZ));
            PointF end9 = VectorPointF(new CVector3D(0, V.mY, V.mZ));
            mGraph.DrawLine(new Pen(new SolidBrush(Color.Gray), 1), origin9, end9);

        }
        public void Graficadora(CVector3D U, CVector3D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();

            PointF origin = VectorPointF(U);
            PointF end = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
        }
        public void GraficadoraMultiplicacion(CVector3D V, PictureBox picCanvas, Color color)
        {
            mGraph = picCanvas.CreateGraphics();

            PointF origin = VectorPointF(new CVector3D(0, 0, 0));
            PointF end = VectorPointF(V);

            PointF origin1 = VectorPointF(new CVector3D(0, 0, 0));
            PointF end1 = VectorPointF(new CVector3D(V.mX, 0, 0));

            PointF origin2 = VectorPointF(new CVector3D(V.mX, 0, 0));
            PointF end2 = VectorPointF(V);

            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin1, end1);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin2, end2);
        }
    }
}
