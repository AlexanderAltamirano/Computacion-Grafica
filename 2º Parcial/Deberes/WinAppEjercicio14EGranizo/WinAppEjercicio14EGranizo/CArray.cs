using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WinAppEjercicio14EGranizo
{
    class CArray
    {
        // Datos miembros - Atributos de la clase.
        private float[] mArray = new float[100];
        private int mNum;

        // Constructor por defecto.
        public CArray()
        {
            Initialize();
        }

        // Constructor copia.
        public CArray(CArray A)
        {
            for (int i = 0; i < mArray.Length; i++)
            {
                this.mArray[i] = A.mArray[i];
            }
            this.mNum = A.mNum;
        }

        public CArray(int longitud)
        {
            mArray = new float[longitud];
            Initialize();
        }

        public int MNum { get => mNum; set => mNum = value; }
        public float[] MArray { get => mArray; set => mArray = value; }

        // Funciones miembro - Métodos de la clase.
        public void Initialize()
        {
            for (int i = 0; i < mArray.Length; i++)
            {
                mArray[i] = -1.0f;
            }
            mNum = 0;
        }

        public void Insert(TextBox txtData, ListBox lstData)
        {
            if (mNum < mArray.Length)
            {
                try
                {
                    mArray[mNum] = float.Parse(txtData.Text);
                    lstData.Items.Add(mArray[mNum].ToString());
                    mNum++;
                }
                catch
                {
                    MessageBox.Show("Ingrese un numero!");
                }
                txtData.Text = "";
                txtData.Focus();
            }
        }

        public void Sort(ListBox lstArray)
        {
            int i, j; float temp;

            lstArray.Items.Clear();

            for (i = 0; i < mNum; i++)
            {
                for (j = i + 1; j < mNum; j++)
                {
                    if (mArray[i] > mArray[j])
                    {
                        temp = mArray[i];
                        mArray[i] = mArray[j];
                        mArray[j] = temp;
                    }
                }
            }

            for (i = 0; i < mNum; i++)
            {
                lstArray.Items.Add(mArray[i].ToString());
            }
        }

        public void Intercalate(CArray A, CArray B, ListBox lstC)
        {
            int j, k;

            j = k = 0;

            this.mNum = A.mNum + B.mNum;

            if (mNum > 0)
            {
                for (int i = 0; i < mNum; i++)
                {
                    if (i % 2 == 0)
                    {
                        mArray[i] = A.mArray[j];
                        j++;
                    }
                    else
                    {
                        mArray[i] = B.mArray[k];
                        k++;
                    }
                    if (mArray[i] != -1)
                    {
                        lstC.Items.Add(mArray[i].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("INGRESE PRIMERO LOS ELEMENTOS DE LOS ARREGLOS");
            }
        }
    }
}
