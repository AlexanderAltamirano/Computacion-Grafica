using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppNumericSeries
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSum1_Click(object sender, EventArgs e)
        {
            frmSum1 ObjectForm = new frmSum1();
            ObjectForm.Show();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            frmFactorial ObjectForm = new frmFactorial();
            ObjectForm.Show();
        }

        private void btnSerieNumE_Click(object sender, EventArgs e)
        {
            frmSerieNumE ObjectForm = new frmSerieNumE();
            ObjectForm.Show();
        }

        private void btnSerieSin_Click(object sender, EventArgs e)
        {
            frmSerieSin ObjectForm = new frmSerieSin();
            ObjectForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
