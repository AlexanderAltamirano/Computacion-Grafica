using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        private CArray A = new CArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            A.RemoveElement(txtDataA);
            A.Print(lstArrayA);
        }

        private void btnInsertA_Click(object sender, EventArgs e)
        {
            A.Insert(txtA, lstArrayA);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
