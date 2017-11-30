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
    public partial class frmSerieNumE : Form
    {
        private CSerie ObjectSerie = new CSerie();

        public frmSerieNumE()
        {
            InitializeComponent();
        }

        private void frmSerieNumE_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectSerie.ReadData(txtNum, txtX);
            ObjectSerie.SerieNumE();
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
