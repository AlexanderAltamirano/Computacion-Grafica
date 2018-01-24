using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp361
{
    public partial class frmMenu : Form
    {
        frmFuncion24 funcion = new frmFuncion24();
        frmFuncion25 funcion2 = new frmFuncion25();
        frmFuncion23 funcion3 = new frmFuncion23();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFuncion1_Click(object sender, EventArgs e)
        {
            funcion3.Show();
        }

        private void btnFuncion2_Click(object sender, EventArgs e)
        {
            funcion.Show();

        }

        private void btnFuncion3_Click(object sender, EventArgs e)
        {
            funcion2.Show();
        }
    }
}
