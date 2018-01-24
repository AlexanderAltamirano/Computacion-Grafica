using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba2AltamiranoTualle
{
    class CArrayEncryptacion
    {

        // Datos miembros - Atributos de la clase.
        private int[] mArray = new int[20];
        private int[] mArrayDes = new int[20];
        private int[] mArrayAuxiliar = new int[20];
        private int mNum, ultimo;

        // Constructores de la clase.

        // Constructor por defecto.
        public CArrayEncryptacion()
        {
            Initialize();
        }

        // Constructor copia.
        public CArrayEncryptacion(CArrayEncryptacion A)
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

        public void EncrypCedula(TextBox txtCedula, ListBox lstBinarios, ListBox lstProcess)
        {

            lstBinarios.Items.Clear();
            lstProcess.Items.Clear();

            lstProcess.Items.Add(txtCedula.Text);
            Insert(txtCedula);                
            CopyDos();
            PrintCopyDos(txtCedula.Text, lstProcess);
            Duplicate();
            ChangePositions();
            PrintProcess(lstProcess);
            Change();
            PrintProcess(lstProcess);
            Copy();
            ultimo = Burbuja();
            lstProcess.Items.Add(ultimo.ToString());
            Max(ultimo);
            PrintFinalProcess(lstProcess);
            for (int i = 0; i < mNum; i++)
            {
                mArray[i] = (int)ChangeIntBinary(mArray[i]);

            }
                
            printBinary(lstBinarios);
        

        }

        


        public void Insert(TextBox txtCedula)
        {
            Initialize();
            int auxiliar;
            if (mNum < mArray.Length)
            {
                auxiliar = int.Parse(txtCedula.Text);
                int num = 0, coc, res;
                do
                {
                    coc = auxiliar / 10;
                    res = auxiliar % 10;
                    auxiliar = coc;
                    mArrayAuxiliar[num] = res;

                    num++;
                    mNum++;
                }

                while (coc != 0);
                for (int i = 0, j = mNum - 1; i < mNum; i++, j--)
                {
                    mArray[i] = mArrayAuxiliar[j];
                }
                txtCedula.Focus();
            }
        }

        public void CopyDos()
        {
            for (int i = 0; i < mNum; i++)
            {
                mArrayDes[i] = mArray[i];
            }
        }

        public void PrintCopyDos(String cedula, ListBox lstProcess)
        {

            String total = "";

            total = cedula + "  -  " + cedula;
            //for(int i=0; i<20; i++)
            lstProcess.Items.Add(total);

        }

        public void Duplicate()
        {
            int aux = mNum;
            for (int i = 0; i < aux; i++)
            {
                mArray[mNum] = mArray[i];
                mNum++;
            }
        }

        public void ChangePositions()
        {
            int auxilar;
            for (int i = 0; i < mNum - 1; i++)
            {
                auxilar = mArray[i + 1];
                mArray[i + 1] = mArray[i];
                mArray[i] = auxilar;
                i++;
            }
        }

        public void Change()
        {
            int auxilar;
            for (int i = 0, j = 5, k = 14; i < 5; i++, j++, k--)
            {
                auxilar = mArray[k];
                mArray[k] = mArray[j];
                mArray[j] = auxilar;
            }
        }

        public void Copy()
        {
            for (int i = 0; i < mNum; i++)
            {
                mArrayAuxiliar[i] = mArray[i];
            }
        }

        public int Burbuja()
        {
            int i, j; int temp;

            for (i = 0; i < mNum; i++)
            {
                for (j = i + 1; j < mNum; j++)
                {
                    if (mArrayAuxiliar[i] > mArrayAuxiliar[j])
                    {
                        temp = mArrayAuxiliar[i];
                        mArrayAuxiliar[i] = mArrayAuxiliar[j];
                        mArrayAuxiliar[j] = temp;
                    }
                }
            }
            return mArrayAuxiliar[mNum - 1];
        }

        public void Max(int ultimo)
        {
            for (int i = 0; i < mNum; i++)
            {
                mArray[i] = mArray[i] * ultimo;
            }
        }

        public void PrintFinalProcess(ListBox lstProcess)
        {
            String total = "";

            for (int i = 0; i < 20; i++)
            {
                total = total + mArray[i].ToString();
                total = total + " ";
            }
            lstProcess.Items.Add(total);

        }

        public long ChangeIntBinary(int numDecimal)
        {
            long D, R, c;
            long j; //Contador (Potencia).
            long sum = 0; // Acumulador (Sumatoria).
            D = numDecimal;
            j = 0;
            do
            {
                c = D / 2;
                R = D % 2;
                sum = (long)(sum + R * Math.Pow(10, j));
                D = c;
                j++;
            } while (c != 0);
            return (sum);
        }

        public void printBinary(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas = mArray[i].ToString();

                lstBinarios.Items.Add(cadenas);
            }

        }








        public void InsertProcess(TextBox txtCedula, ListBox lstProcess)
        {
            Initialize();
            int auxiliar;
            if (mNum < mArray.Length)
            {
                auxiliar = int.Parse(txtCedula.Text);
                int num = 0, coc, res;
                do
                {
                    coc = auxiliar / 10;
                    res = auxiliar % 10;
                    auxiliar = coc;
                    mArrayAuxiliar[num] = res;

                    num++;
                    mNum++;
                }

                while (coc != 0);
                for (int i = 0, j = mNum - 1; i < mNum; i++, j--)
                {
                    mArray[i] = mArrayAuxiliar[j];
                }
                print(lstProcess);

            }
        }

        public void print(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas += mArray[i].ToString();
                cadenas += " ";
            }
            lstBinarios.Items.Add(cadenas);
        }


        public void PrintCopy(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas += mArray[i].ToString();
            }
            lstBinarios.Items.Add(cadenas);
        }

        public void Print(ListBox lstData)
        {
            lstData.Items.Clear();
            for (int i = 0; i < this.mNum; i++)
            {
                lstData.Items.Add(this.mArray[i].ToString());
            }
        }

        public void PrintProcess(ListBox lstProcess)
        {
            String total = "";

            for (int i = 0; i < 20; i++)
            {
                total = total + mArray[i].ToString();
                if (i == 9)
                {
                    total = total + "  -  ";
                }
            }
            lstProcess.Items.Add(total);

        }


    }

}

