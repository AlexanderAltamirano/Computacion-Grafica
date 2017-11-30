using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppNumericSeries
{
    class CSerie
    {
        // Datos miembro - Atributos de la clase.
        long mNum;
        float mX;
        float mResult;
        // Constructor por defecto.
        public CSerie()
        {
            mNum = 0L; mX = 0.0f; mResult = 0.0f;
        }

        // Funciones miembro - Métodos de la clase.

        public void ReadData(TextBox txtNum)
        {
            mNum = long.Parse(txtNum.Text);
        }

        public void ReadData(TextBox txtNum, TextBox txtX)
        {
            mNum = long.Parse(txtNum.Text);
            mX = long.Parse(txtX.Text);
        }

        public void PrintData(TextBox txtSerie)
        {
            txtSerie.Text = mResult.ToString();
        }

        public void Sum1()
        {
            long i; float sum = 0.0f;
            for(i = 1; i <= mNum; i++)
            {
                sum = sum + i;
            }
            mResult = sum;
        }

        public void Factorial()
        {
            long i; float prod = 1.0f;
            for (i = 1; i <= mNum; i++)
            {
                prod = prod * i;
            }
            mResult = prod;
        }

        public float Factorial(long n)
        {
            long i; float prod = 1.0f;
            for (i = 1; i <= n; i++)
            {
                prod = prod * i;
            }
            return(prod);
        }

        public void SerieNumE()
        {
            long i; float sum = 0.0f;
            for (i = 0; i <= mNum - 1; i++)
            {
                sum = sum + (float)Math.Pow(mX, i) / Factorial(i);
            }
            mResult = sum;
        }

        public void SerieSin()
        {
            long i; float sum = 0.0f;

            mX = ConversionGradesToRadians();

            for (i = 1; i <= mNum; i++)
            {
                sum = sum + ((float)Math.Pow(-1.0, i + 1) * (float)Math.Pow(mX, 2 * i - 1)) / 
                      Factorial(2 * i - 1);
            }
            mResult = sum;
        }

        private float ConversionGradesToRadians()
        {
            return (mX * (float)Math.PI / 180);
        }

    }
}
