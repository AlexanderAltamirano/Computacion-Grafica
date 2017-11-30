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
    public partial class frmSquare : Form
    {
        CAstericsFigure ObjCAstericsFigure = new CAstericsFigure();
        public frmSquare()
        {
            InitializeComponent();
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.ReadData(txtNum);
            ObjCAstericsFigure.GraphSquare(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.initializateTriangle(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
