using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppSetsOperations
{
    class CSet
    {
        // Datos miembros - Atributos de la clase.
        private int[] mArray = new int[100];
        private int mNum;

        // Constructores de la clase.

        // Constructor por defecto.
        public CSet()
        {
            Initialize();
        }

        // Constructor copia.
        public CSet(CSet A)
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
            for (int i = 0; i < mArray.Length; i++)
            {
                mArray[i] = -1;
            }
            mNum = 0;
        }

        public bool Insert(TextBox txtData, ListBox lstData)
        {
            for (int i = 0; i < mNum; i++)
            {
                if (mArray[i] == int.Parse(txtData.Text))
                {
                    txtData.Text = "";
                    txtData.Focus();
                    return (false);
                }
            }

            if (mNum < mArray.Length)
            {
                mArray[mNum] = int.Parse(txtData.Text);
                lstData.Items.Add(mArray[mNum].ToString());
                mNum++;
                txtData.Text = "";
                txtData.Focus();
                return (true);
            }

            return (false);
        }

        public bool Insert(int data)
        {
            for (int i = 0; i < mNum; i++)
            {
                if (mArray[i] == data)
                {                    
                    return (false);
                }
            }

            if (mNum < mArray.Length)
            {
                mArray[mNum] = data;                
                mNum++;                
                return (true);
            }

            return (false);
        }

        public void Copy(CSet Origin, CSet Destiny)
        {
            for (int i = 0; i < Origin.mNum; i++)
            {
                Destiny.mArray[i] = Origin.mArray[i];
            }
            Destiny.mNum = Origin.mNum;
        }

        public void Copy(CSet Origin, CSet Destiny, ListBox lstData)
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
        
        public void RemoveElement(TextBox txtData)
        {
            int i;
            float data = float.Parse(txtData.Text);

            for (i = 0; i < mNum; i++)
            {
                if (mArray[i] == data)
                {
                    for (; i < mNum - 1; i++)
                    {
                        mArray[i] = mArray[i + 1];
                    }
                    mNum = mNum - 1;
                }
            }
            txtData.Text = "";
        }

        public CSet Union(CSet A, CSet B)
        {
            CSet Temp = new CSet(A);

            for(int i = 0; i < B.mNum; i++)
            {
                Temp.Insert(B.mArray[i]);
            }
            return (Temp);
        }

        public CSet Union(CSet B)
        {
            CSet Temp = new CSet(this);

            for (int i = 0; i < B.mNum; i++)
            {
                Temp.Insert(B.mArray[i]);
            }
            return (Temp);
        }

        public CSet Interjection(CSet A, CSet B)
        {
            CSet Temp = new CSet();

            for (int i = 0; i < A.mNum; i++)
            {
                for(int j = 0; j < B.mNum; j++)
                {
                    if(A.mArray[i] == B.mArray[j])
                    {
                        Temp.Insert(A.mArray[i]);
                        break;
                    }
                }
            }
            return (Temp);
        }

        public CSet Interjection(CSet B)
        {
            CSet Temp = new CSet();

            for (int i = 0; i < mNum; i++)
            {
                for (int j = 0; j < B.mNum; j++)
                {
                    if (mArray[i] == B.mArray[j])
                    {
                        Temp.Insert(mArray[i]);
                        break;
                    }
                }
            }
            return (Temp);
        }

    }
}
