using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinappVectores
{
    class CVector2D
    {
        private float mX;
        private float mY;

        //Funciones miembro - Metodos.

        //Propiedades - Descriptores de acceso (set y get).

        //Función dual

        public float X
        {
            get { return mX; }
            set { mX = value; }
        }

        public float Y
        {
            get => mY; set => mY = value; 
        }

        public CVector2D()
        {
            mX = 0.0f; mY = 0.0f;
        }

        public CVector2D(float x, float y)
        {
            mX = x; mY = y;
        }

        public void readData(NumericUpDown nudXVector, NumericUpDown nudYVector)
        {
            mX = (float)(nudXVector.Value);
            mY = (float)(nudYVector.Value);
        }

        public void printData(TextBox txtXVector, TextBox txtYVector)
        {
            txtXVector.Text = mX.ToString();
            txtYVector.Text = mY.ToString();
        }

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

        public CVector2D Subtraction(CVector2D V)
        {
            CVector2D Temp = new CVector2D();

            Temp.mX = mX - V.mX;
            Temp.mY = mY - V.mY;

            return (Temp);
        }
    }
}
