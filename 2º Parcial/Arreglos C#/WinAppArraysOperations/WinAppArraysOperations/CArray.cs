using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppArraysOperations
{
    class CArray
    {
        // Datos miembros - Atributos de la clase.
        private float[] mArray = new float[100];
        private int mNum;

        // Constructores de la clase.
        
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

        // Funciones miembro - Métodos de la clase.
        public void Initialize()
        {
            for(int i = 0; i < mArray.Length; i++)
            {
                mArray[i] = -1.0f;
            }
            mNum = 0;
        }

        public void Insert(TextBox txtData, ListBox lstData)
        {
            if(mNum < mArray.Length)
            {
                mArray[mNum] = float.Parse(txtData.Text);
                lstData.Items.Add(mArray[mNum].ToString());
                mNum++;
                txtData.Text = "";
                txtData.Focus();
            }
        }

        public void Sum(TextBox txtSigma)
        {
            float acum = 0.0f;
            for(int i = 0; i < mNum; i++)
            {
                acum = acum + mArray[i];
            }
            txtSigma.Text = acum.ToString();
        }

        public float Sum()
        {
            float acum = 0.0f;
            for (int i = 0; i < mNum; i++)
            {
                acum = acum + mArray[i];
            }
            return (acum);
        }

        public void Media(TextBox txtMedia)
        {
            float sum = Sum();
            float prom = sum / mNum;
            txtMedia.Text = prom.ToString();    
        }

        public void Copy(CArray Origin, CArray Destiny)
        {
            for (int i = 0; i < Origin.mNum; i++)
            {
                Destiny.mArray[i] = Origin.mArray[i];
            }
            Destiny.mNum = Origin.mNum; 
        }

        public void Copy(CArray Origin, CArray Destiny, ListBox lstData)
        {
            for (int i = 0; i < Origin.mNum; i++)
            {
                Destiny.mArray[i] = Origin.mArray[i];
            }
            Destiny.mNum = Origin.mNum;
            Print(lstData);
        }

        public void Print(ListBox lstData)
        {
            lstData.Items.Clear();
            for (int i = 0; i < this.mNum; i++)
            {
                lstData.Items.Add(this.mArray[i].ToString());
            }
        }

        public void Reverse()
        {
            int i, j;
            CArray Temp = new CArray();

            for(i = 0, j = this.mNum - 1; i < this.mNum; i++, j--)
            {
                Temp.mArray[j] = this.mArray[i];
            }
            Temp.mNum = this.mNum;

            Copy(Temp, this);
        }

        public void Sort()
        {
            int i, j; float temp;

            for(i = 0; i < mNum; i++)
            {
                for (j = i + 1; j < mNum; j++)
                {
                    if(mArray[i] > mArray[j])
                    {
                        temp = mArray[i];
                        mArray[i] = mArray[j];
                        mArray[j] = temp;
                    }
                }
            }
        }

        public void RemoveElement(TextBox txtData)
        {
            int i;
            float data = float.Parse(txtData.Text);            

            for (i = 0; i < mNum; i++)
            {
                if(mArray[i] == data)
                { 
                    for ( ; i < mNum - 1; i++)
                    {
                        mArray[i] = mArray[i + 1];
                    }
                    mArray[i] = -1;
                    mNum = mNum - 1;
                }
            }
            txtData.Text = "";
        }


        public void GenerateRandomData(ListBox lstData)
        {
            int index = 0;
            int i;
            Random RandomNumber = new Random();
            mNum = 20;

            for(i = 0; i < mNum; i++)
            {
                index = RandomNumber.Next(0, 21);
                mArray[i] = index;
            }

            lstData.Items.Clear();
            for (i = 0; i < this.mNum; i++)
            {
                lstData.Items.Add(this.mArray[i].ToString());
            }
        }


    }
}
