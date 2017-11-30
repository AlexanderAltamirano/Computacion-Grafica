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
    public partial class frmSerieSin : Form
    {
        private CSerie ObjectSerie = new CSerie();

        public frmSerieSin()
        {
            InitializeComponent();
        }

        private void frmSerieSin_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectSerie.ReadData(txtNum, txtX);
            ObjectSerie.SerieSin();
            ObjectSerie.PrintData(txtSerie);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
