using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio14EGranizo
{
    public partial class frmArrays : Form
    {
        CArray A = new CArray();
        CArray B = new CArray();
        CArray C = new CArray(200);

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnInsertA_Click(object sender, EventArgs e)
        {
            A.Insert(txtA, lstArrayA);
        }

        private void btnInsertB_Click(object sender, EventArgs e)
        {
            B.Insert(txtB, lstArrayB);
        }

        private void btnIntercalate_Click(object sender, EventArgs e)
        {
            if (A.MNum == 0 && B.MNum == 0)
            {
                MessageBox.Show("NO SE PUEDE REALIZAR LA INTERCALACION DE ELEMENTOS! SIN LOS 2 ARREGLOS", "ERROR");
            }
            else
            {
                MessageBox.Show("PRIMERAMENTE SE ORDENARA LOS ARREGLOS PARA INTERCALARLOS ASCENDENTEMENTE");
                A.Sort(lstArrayA);
                B.Sort(lstArrayB);
                C.Intercalate(A,B,lstArrayC);
            }
        }
    }
}
