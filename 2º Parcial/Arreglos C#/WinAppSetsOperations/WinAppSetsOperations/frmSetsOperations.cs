using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSetsOperations
{
    public partial class frmSetsOperations : Form
    {
        // Datos miembro - Atributos de la clase.
        private CSet A = new CSet();
        private CSet B = new CSet();
        private CSet C = new CSet();
        private CSet D = new CSet();

        public frmSetsOperations()
        {
            InitializeComponent();
        }

        private void frmSetsOperations_Load(object sender, EventArgs e)
        {
            CSet D = new CSet(B);
        }

        private void btnInsertA_Click(object sender, EventArgs e)
        {
            A.Insert(txtA, lstSetA);
        }

        private void btnInsertB_Click(object sender, EventArgs e)
        {
            B.Insert(txtB, lstSetB);
        }

        private void btnInsertC_Click(object sender, EventArgs e)
        {

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            C = C.Union(A, B);
            // C = A.Union(B);
            C.Print(lstSetC);
        }

        private void btnInterjection_Click(object sender, EventArgs e)
        {
            // C = C.Interjection(A, B);
            C = A.Interjection(B);
            C.Print(lstSetC);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
