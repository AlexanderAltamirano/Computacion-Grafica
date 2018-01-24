using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WinAppPruebaSegundoParcial
{
    class CArrayEncriptacion
    {
         // Datos miembros - Atributos de la clase.
        private int[] mArray = new int[1600];
        private int[] mArrayDes = new int[1600];
        private int[] mArrayAuxiliar = new int[1600];
        private int mNum, ultimo;
       
        // Constructores de la clase.
        
        // Constructor por defecto.
        public CArrayEncriptacion()
        {
            Initialize();
        }

        // Constructor copia.
        public CArrayEncriptacion(CArrayEncriptacion A)
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
                mArray[i] = -1;
            }
            mNum = 0;
        }
        public bool validarCedula(TextBox txtCedula)
        {
            int CI, coc;
            int res, sumpar, sumimpar, mul, sumtotal, cont, digverif;
            CI = int.Parse(txtCedula.Text);
            sumimpar = sumpar = 0;
            cont = 1;
            digverif = CI % 10;
            CI = CI / 10;
            do
            {
                coc = CI / 10;
                res = CI % 10;
                if (cont == 1)
                {
                    mul = res * 2;
                    if (mul > 9)
                    {
                        mul -= 9;
                    }
                    sumimpar += mul;
                    cont = 2;
                }
                else
                {
                    sumpar += res;
                    cont = 1;
                }
                CI = coc;
            }
            while (coc != 0);
            sumtotal = sumimpar + sumpar;
            res = (10 - (sumtotal % 10));
            if (res == 10)
                res = 0;
            if (res == digverif)
                return true;
            else
                return false;


        }
        public void EncriptarCedula(TextBox txtCedula, ListBox lstBinarios)
        {
            try
            {
                bool bandera; 
                lstBinarios.Items.Clear();
                bandera = validarCedula(txtCedula);
                if (bandera == true)
                {

                    Insert(txtCedula);
                    CopyDos();
                    duplicar();
                    //imprimir(lstBinarios);
                    cambiarPosiciones();
                    // imprimir(lstBinarios);
                    intercambio();
                    Copy();
                    ultimo = Sort();
                    maximo(ultimo);
                    //imprimir(lstBinarios);
                    for (int i = 0; i < mNum; i++)
                    {
                        mArray[i] = (int)ConvertirDecimalABinario(mArray[i]);

                    }
                    imprimirbinarios(lstBinarios);
                }
                else
                {
                    MessageBox.Show("Número de cédula no válido...");
                }

               
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
           
            
        }
        public void DesencriptarCedula(ListBox lstBinarios,ListBox lstDesencriptacion)
        {
            /*for (int i = 0; i < mNum; i++)
            {
                mArrayDes[i] = mArray[i]/ultimo;

            }
            intercambioDos();
            cambiarPosicionesDos();
            Desduplicar();*/
            String cadenas = "";
            for (int i = 0; i < mNum/2; i++)
            {
                cadenas += mArrayDes[i].ToString();
                cadenas += " ";
            }
            lstDesencriptacion.Items.Add(cadenas); 

        }
        public void Insert(TextBox txtCedula)
        {
            Initialize();
            int auxiliar;
            if(mNum < mArray.Length)
            {
                auxiliar=int.Parse(txtCedula.Text);
                int num=0,coc,res;
                do
                {
                    coc=auxiliar/10;
                    res=auxiliar%10;
                    auxiliar=coc;
                    mArrayAuxiliar[num]=res;
                    
                    num++;
                    mNum++;
                    }

                while (coc!=0);
                for (int i = 0, j = mNum-1; i < mNum; i++, j--)
                {
                    mArray[i] = mArrayAuxiliar[j];
                }
              
                txtCedula.Text = "";
                txtCedula.Focus();
                }
        }

        public void duplicar()
        {
            int aux = mNum;
            for (int i = 0; i < aux; i++)
            {
                mArray[mNum] = mArray[i];
                mNum++;
            }
        }
        public void Desduplicar()
        {
            mNum = mNum / 2;
        }
        public void cambiarPosiciones()
        {
            int auxilar;
            for (int i = 0; i < mNum-1; i++)
            {
                auxilar = mArray[i + 1];
                mArray[i+1] = mArray[i];
                mArray[i]=auxilar;
                i++;
            }
        }
        public void cambiarPosicionesDos()
        {
            int auxilar;
            for (int i = 0; i < mNum - 1; i++)
            {
                auxilar = mArrayDes[i + 1];
                mArrayDes[i + 1] = mArrayDes[i];
                mArrayDes[i] = auxilar;
                i++;
            }
        }

        public void intercambio()
        {
            int auxilar;
            for (int i = 0,j=5,k=14; i < 5; i++,j++,k--)
            {
                auxilar = mArray[k];
                mArray[k] = mArray[j];
                mArray[j] = auxilar;
            }
        }
        public void intercambioDos()
        {
            int auxilar;
            for (int i = 0, j = 5, k = 14; i < 5; i++, j++, k--)
            {
                auxilar = mArrayDes[k];
                mArrayDes[k] = mArrayDes[j];
                mArrayDes[j] = auxilar;
            }
        }

        public void imprimir(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas += mArray[i].ToString();
                cadenas += " ";
            }
            lstBinarios.Items.Add(cadenas); 
        }
        public void imprimirbinarios(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas = mArray[i].ToString();
                
                lstBinarios.Items.Add(cadenas);
            }
           
        }
        public long ConvertirDecimalABinario(int numDecimal)
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
                sum =(long)(sum + R * Math.Pow(10, j));
                D = c;
                j++;
            } while (c != 0);
            return (sum);
        }
        public void imprimircopy(ListBox lstBinarios)
        {
            String cadenas = "";
            for (int i = 0; i < mNum; i++)
            {
                cadenas += mArray[i].ToString();
            }
            lstBinarios.Items.Add(cadenas);
        }


        public void Copy()
        {
            for (int i = 0; i < mNum; i++)
            {
                mArrayAuxiliar[i] = mArray[i];
            }
        }

        public void CopyDos()
        {
            for (int i = 0; i < mNum; i++)
            {
                mArrayDes[i] = mArray[i];
            }
        }
        public void maximo(int ultimo)
        {
            for (int i = 0; i < mNum; i++)
            {
                mArray[i] = mArray[i]*ultimo;
            }
        }

        public void Copy(CArrayEncriptacion Origin, CArrayEncriptacion Destiny, ListBox lstData)
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


        public int Sort()
        {
            int i, j; int temp;

            for(i = 0; i < mNum; i++)
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
            return mArrayAuxiliar[mNum-1];
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
