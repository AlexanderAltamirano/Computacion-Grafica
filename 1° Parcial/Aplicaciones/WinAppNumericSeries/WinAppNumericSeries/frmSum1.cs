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
    public partial class frmSum1 : Form
    {
        private CSerie ObjectSerie = new CSerie();
        public frmSum1()
        {
            InitializeComponent();
        }

        private void frmSum1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectSerie.ReadData(txtNum);
            ObjectSerie.Sum1();
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
