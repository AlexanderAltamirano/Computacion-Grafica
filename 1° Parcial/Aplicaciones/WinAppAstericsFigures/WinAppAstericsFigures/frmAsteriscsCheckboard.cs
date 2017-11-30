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
    public partial class frmAsteriscsCheckboard : Form
    {
        CAstericsFigure ObjCAstericsFigure = new CAstericsFigure();
        public frmAsteriscsCheckboard()
        {
            InitializeComponent();
        }

        private void frmAsteriscsCheckboard_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.ReadData(txtNum);
            ObjCAstericsFigure.GraphAsteriscsCheckboard(lstFigure);
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
