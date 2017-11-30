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
    public partial class frmRectangle : Form
    {
        CAstericsFigure ObjCAstericsFigure = new CAstericsFigure();
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.ReadData(txtA, txtB);
            ObjCAstericsFigure.GraphRectangle(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.initializateRectangle(txtA, txtB, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}
