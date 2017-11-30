using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmBranch : Form
    {
        CAstericsFigure ObjForm = new CAstericsFigure();

        public frmBranch()
        {
            InitializeComponent();
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjForm.ReadData(txtNum);
            ObjForm.GraphAstercisBranch(lstBranch);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
