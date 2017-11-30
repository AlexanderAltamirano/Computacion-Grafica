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
    public partial class frmTNumbers : Form
    {
        CAstericsFigure ObjTNumbers = new CAstericsFigure();
        public frmTNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTNumbers.ReadData(txtNum);
            ObjTNumbers.GraphAstericsTriangleNumber(lstTNumbers);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTNumbers_Load(object sender, EventArgs e)
        {

        }
    }
}
