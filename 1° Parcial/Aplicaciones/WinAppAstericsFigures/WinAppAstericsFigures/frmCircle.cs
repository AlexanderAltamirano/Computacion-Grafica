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
    public partial class frmCircle : Form
    {
        CAstericsFigure ObjCAstericsFigure = new CAstericsFigure();
        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.ReadData(txtNum);
            ObjCAstericsFigure.GraphCircle(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.initializateTriangle(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
