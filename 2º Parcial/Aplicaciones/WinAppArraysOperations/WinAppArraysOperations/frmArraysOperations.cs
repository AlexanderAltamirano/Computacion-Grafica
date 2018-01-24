using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArraysOperations
{
    public partial class frmArraysOperations : Form
    {
        // Datos miembro - Atributos de la clase.
        private CArray A = new CArray();
        private CArray B = new CArray();
        private CArray C = new CArray();
        private CArray D = new CArray();

        public frmArraysOperations()
        {
            InitializeComponent();
        }

        private void frmArraysOperations_Load(object sender, EventArgs e)
        {
            CArray D = new CArray(B);
        }

        private void btnInsertA_Click(object sender, EventArgs e)
        {
            A.Insert(txtA, lstArrayA);
        }

        private void btnInsertB_Click(object sender, EventArgs e)
        {
            B.Insert(txtB, lstArrayB);
        }

        private void btnInsertC_Click(object sender, EventArgs e)
        {

        }

        private void btnSigma_Click(object sender, EventArgs e)
        {
            A.Sum(txtSigmaA);
            B.Sum(txtSigmaB);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            A.Media(txtMediaA);
            B.Media(txtMediaB);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            A.Copy(A, C);
            C.Print(lstArrayC);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            A.Reverse();
            A.Print(lstArrayA);

            B.Reverse();
            B.Print(lstArrayB);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            A.Sort();
            A.Print(lstArrayA);

            B.Sort();
            B.Print(lstArrayB);
        }

        private void btnGenerateRandomArray_Click(object sender, EventArgs e)
        {
            A.GenerateRandomData(lstArrayA);
            B.GenerateRandomData(lstArrayB);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            A.RemoveElement(txtDataA);
            A.Print(lstArrayA);
        }

        private void lstArrayA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
