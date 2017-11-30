using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    class CAstericsFigure
    {
        //Datos miembro - Atributos
        private int mNum; //Número de líneas
        private int mRow; //Número de filas
        private String mBlanks;
        private String mAsterics;
        private String mTotalString;
        private int mA, mB;
        //Funciones miembro - Métodos
        public CAstericsFigure()
        {
            mNum = 0; mRow = 0; 
            mBlanks = ""; mAsterics = ""; mTotalString="";
        }

        public void ReadData(TextBox txtNum){
            mNum = int.Parse(txtNum.Text);
        }
        public void ReadData(TextBox txtA, TextBox txtB)
        {
            mA = int.Parse(txtA.Text);
            mB = int.Parse(txtA.Text);
        }

        public void initializateTriangle(TextBox txtNum, ListBox lstFigure)
        {
            txtNum.Clear();
            lstFigure.Items.Clear();
            txtNum.Focus();
        }

        public void initializateRectangle(TextBox txtA, TextBox txtB, ListBox lstFigure)
        {
            txtA.Clear();
            txtB.Clear();
            lstFigure.Items.Clear();
            txtA.Focus();
        }

        public void GraphAstericsTriangle(ListBox lstFigure){
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            //Bucle externo incremental para controlar las filas
            for(mRow=1;mRow <=mNum; mRow++){
                mBlanks=""; mAsterics=""; mTotalString="";
                //Bucle interno decremental, para controlar los espacios en blanco.
                for(contBlanks= mNum - mRow;contBlanks > 0; contBlanks--){
                mBlanks = mBlanks + " ";
                }
                //Bucle interno incremental, para controlar los asteriscos.
                for(contAsterics= 1;contAsterics <2 * mRow; contAsterics++){
                mAsterics = mAsterics +"*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
        }
        public void GraphCircle(ListBox lstFigure)
        {
            for (int j = 0; j <= mNum * 2; j++)
            {
                mTotalString = " "; mBlanks = ""; mAsterics = "";
                for (int i = 0; i <= mNum * 2; i++)
                {
                    if (Math.Pow(i - mNum, 2) + Math.Pow(j - mNum, 2) <= (int)Math.Pow(mNum, 2))
                    {
                        mAsterics = "*";
                        mTotalString += mAsterics;
                    }
                    else
                    {
                        mBlanks = " ";
                        mTotalString += mBlanks;
                    }
                }
                
                lstFigure.Items.Add(mTotalString);
            }
        }
        public void GraphRectangle(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();
            for (mRow = 1; mRow <= mB; mRow++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                if (mRow == 1 || mRow == mB)
                {
                    //Bucle Interno para controlar los asteriscos
                    for (contAsterics = 1; contAsterics <= mA; contAsterics++)
                    {
                        mAsterics = mAsterics + "*";
                    }
                    lstFigure.Items.Add(mAsterics);
                }
                else
                {
                    mAsterics = "*";
                    for (contBlanks = 1; contBlanks <= mA - 2; contBlanks++)
                    {
                        mBlanks = mBlanks + ".";
                    }
                    mTotalString = mAsterics + mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
        }
         public void GraphSquare(ListBox lstFigure)
         {
            lstFigure.Items.Clear();
            for(int i=0;i<mNum;i++)
            {
                mTotalString = ""; mBlanks = ""; mAsterics = "";
                for(int j = 0; j < mNum; j++)
                {
                    mBlanks = " ";
                    mTotalString += mBlanks;
                    mAsterics = " *";
                    mTotalString += mAsterics;   
                }
                lstFigure.Items.Add(mTotalString);
            }
        }
        public void GraphAstericsRhombus(ListBox lstFigure){
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            //Converisón a par
            if((mNum + 1) % 2 == 0)
            {
                mNum = mNum + 1; mNum = mNum / 2;
            }

            //Bucle externo incremental
            for(mRow=1;mRow <=mNum; mRow++){
                mBlanks=""; mAsterics=""; mTotalString="";
                //Bucle interno decremental, para controlar los espacios en blanco.
                for(contBlanks= mNum - mRow;contBlanks > 0; contBlanks--){
                mBlanks = mBlanks + " ";
                }
                //Bucle interno incremental, para controlar los asteriscos.
                for(contAsterics= 1;contAsterics <2 * mRow; contAsterics++){
                mAsterics = mAsterics +"*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
            //Bucle externo incremental para controlar las filas
            for(mRow=mNum - 1;mRow > 0; mRow--){
                mBlanks=""; mAsterics=""; mTotalString="";
                //Bucle interno decremental, para controlar los espacios en blanco.
                for(contBlanks= mNum - mRow;contBlanks > 0; contBlanks--){
                mBlanks = mBlanks + " ";
                }
                //Bucle interno incremental, para controlar los asteriscos.
                for(contAsterics= 1;contAsterics <2 * mRow; contAsterics++){
                mAsterics = mAsterics +"*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
        }
        public void GraphAsteriscsCheckboard(ListBox lstFigure)
        {
            int contador = 1;
            lstFigure.Items.Clear();
            for (int i = 0; i < mNum; i++)
            {
                mTotalString = ""; mBlanks = ""; mAsterics = "";
                contador--;
                for (int j = 0; j < mNum; j++)
                {
                    contador++;
                    if (contador % 2 != 0)
                    {
                        mBlanks = "o";
                        mTotalString += mBlanks;
                    }
                    if (contador % 2 == 0)
                    {
                        mAsterics = "x";
                        mTotalString += mAsterics;
                    }

                }
                lstFigure.Items.Add(mTotalString);
            }
        }

    } 

    }
