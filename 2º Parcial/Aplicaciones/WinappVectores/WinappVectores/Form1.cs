using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinappVectores
{
    public partial class frmVectpr2D : Form
    {
        //Datos miembro (Composición multiple). 
        private CVector2D A = new CVector2D();
        private CVector2D B = new CVector2D();
        private CVector2D R = new CVector2D();

        public frmVectpr2D()
        {
            InitializeComponent();
        }

        private void frmVectpr2D_Load(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            A.readData(nudXVectorA, nudYVectorA);
            B.readData(nudXVectorB, nudYVectorB);

            //R = R.Addition(A, B);
            R = A.Addition(B);

            R.printData(txtXVectorR, txtYVectorR);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            A.readData(nudXVectorA, nudYVectorA);
            B.readData(nudXVectorB, nudYVectorB);

            //R = R.Addition(A, B);
            R = A.Subtraction(B);

            R.printData(txtXVectorR, txtYVectorR);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
