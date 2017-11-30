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

        //datos miembro -atributos
        private int mNum;
        private int mRow;
        private String mBlanks;
        private String mAsterics;
        private String mNumbers;
        private String mTotalString;

        //funciones miembro metodos

        //constructor
        public CAstericsFigure()
        {
            mNum = 0; mRow = 0;
            mBlanks = ""; mAsterics = ""; mTotalString = "";

        }
        public void ReadData(TextBox txtNum)
        {
            mNum = int.Parse(txtNum.Text);
             
        }
        public void GraphAstercisTriangle(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();


            //bucle externo incremental para controlar las filas
            for (mRow = 1; mRow <= mNum; mRow++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                //bucle interno decremental para controlar los espacios en blanco
                for (contBlanks = mNum - mRow; contBlanks > 0; contBlanks--)
                {
                    mBlanks = mBlanks + " ";
                }

                //bulce interno incremental para controlar los astericos
                for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                {
                    mAsterics = mAsterics + "*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);

            }

        }
        public void GraphAstercisRumbus(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();


            //bucle externo incremental para controlar las filas
            for (mRow = mNum - 1; mRow > 0; mRow--)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                //bucle interno decremental para controlar los espacios en blanco
                for (contBlanks = mNum - mRow; contBlanks > 0; contBlanks--)
                {
                    mBlanks = mBlanks + " ";
                }

                //bulce interno incremental para controlar los astericos
                for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                {
                    mAsterics = mAsterics + "*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);

            }


        }
        public void GraphAstercisBranch(ListBox lstFigure)
        {
            lstFigure.Items.Clear();

            int i, j, x, y, k;
            for (i = 1; i <= mNum; i++)

            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                for (j = 1; j <= mNum + 1; j++)
                {
                    mBlanks = mBlanks + " ";
                }

                for (y = 1; y <= mNum; y++)
                {
                    if (y <= i)
                    {
                        mAsterics += "*";
                    }
                    /*else
                    {
                        mBlanks = mBlanks + " ";

                    }*/
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);

            }
            i = 0; j = 0; y = 0;
            for (i = 1; i <= mNum; i++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                for (j = 1; j <= 2 * mNum + 1; j++)
                {
                    mBlanks = mBlanks + " ";
                }

                for (y = 1; y <= mNum; y++)
                {
                    if (y <= i)
                    {
                        mAsterics += "*";
                    }
                    /*else
                    {
                        mBlanks = mBlanks + " ";
                    }*/
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
            for (i = 1; i <= mNum; i++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                for (j = 1; j <= 3 * mNum + 1; j++)
                {
                    mBlanks = mBlanks + " ";
                }

                for (y = 1; y <= mNum; y++)
                {
                    if (y <= i)
                    {
                        mAsterics += "*";
                    }
                    /*else
                    {
                        mBlanks = mBlanks + " ";
                    }*/
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }

        }

        public void GraphAstericsFlag(ListBox lstFigure)
        {
            lstFigure.Items.Clear();
            int i, j, x, y;
            for (i = 1; i <= mNum - 1; i++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                for (j = 1; j <= mNum - 1; j++)
                {
                    mBlanks = mBlanks + " ";
                }

                for (y = 1; y <= mNum - 1; y++)
                {
                    if (i >= y)
                    {
                        mAsterics += "*";
                    }

                }

                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
            i = 0; j = 0;
            x = 0; y = 0;

            mBlanks = ""; mAsterics = ""; mTotalString = "";
            for (i = 1; i <= 2 * mNum - 1; i++)
            {

                mAsterics += "*";
                mTotalString = mBlanks + mAsterics;
            }
            //mTotalString = mBlanks + mAsterics;
            lstFigure.Items.Add(mTotalString);


            for (x = 1; x <= mNum - 1; x++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                for (y = 1; y <= mNum; y++)
                {
                    if (y > x)
                    {
                        mAsterics += "*";
                    }
                    else
                    {
                        mBlanks += " ";
                    }

                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }

        }
        public void GraphAstericsTriangleNumber(ListBox lstFigure)
        {
            lstFigure.Items.Clear();
            int i, j, y;

            for (i = 1; i <= mNum; i++)
            {
                mBlanks = ""; mNumbers = ""; mTotalString = "";
                for (j = 1; j <= i; j++)
                {

                    /* mNumbers += j.ToString();
                 mTotalString = mNumbers + mBlanks;*/
                    mNumbers += j.ToString();

                    for (int k = 1; k <= mNum; k++)
                    {
                        //mNumbers += j.ToString();
                        mBlanks += " ";
                    //    mTotalString = mBlanks + mNumbers;

                    }

                   // mTotalString = mNumbers + mBlanks;

                }

                mTotalString = mNumbers + mBlanks;
                lstFigure.Items.Add(mTotalString);


            }


             for (i = mNum - 1; i > 0; i--)
             {
                 mBlanks = ""; mNumbers = ""; mTotalString = "";
                 for (j = 1; j <= i; j++)
                 {
                     mNumbers += j.ToString();

                     for (int k = j; k <= mNum; k++)
                         mBlanks += " ";
                 }


                 mTotalString = mBlanks + mNumbers;
                 lstFigure.Items.Add(mTotalString);
             }
         }
    }

 }


    
           




     
