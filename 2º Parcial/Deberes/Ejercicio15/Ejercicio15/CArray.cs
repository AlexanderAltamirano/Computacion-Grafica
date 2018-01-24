using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio15
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
            for (int i = 0; i < this.mNum; i++)
            {
                this.mArray[i] = A.mArray[i];
            }
            this.mNum = A.mNum;
        }

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
                mArray[mNum] = float.Parse(txtData.Text);
                lstData.Items.Add(mArray[mNum].ToString());
                mNum++;
                txtData.Text = "";
                txtData.Focus();
            }
        }

        public void Copy(CArray Origin, CArray Destiny)
        {
            for (int i = 0; i < Origin.mNum; i++)
            {
                Destiny.mArray[i] = Origin.mArray[i];
            }
            Destiny.mNum = Origin.mNum;
        }

        public void Copy(CArray Destiny)
        {
            for (int i = 0; i < mNum; i++)
            {
                Destiny.mArray[i] = mArray[i];
            }
            Destiny.mNum = mNum;
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
                if(mArray[i]!=-1)
                {
                    lstData.Items.Add(this.mArray[i].ToString());
                }

            }
        }

        public void RemoveElement(TextBox txtData)
        {
            int i;
            int j;
            float data = float.Parse(txtData.Text);

                for (i = 0; i < mNum; i++)
                {
                    if (mArray[i] == data)
                    {

                      mArray[i] = -1;

                    }
                }
            txtData.Text = "";
        }

    }
}
