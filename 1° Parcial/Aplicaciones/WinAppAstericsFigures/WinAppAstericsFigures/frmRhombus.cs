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
    public partial class frmRhombus : Form
    {
        CAstericsFigure ObjCAstericsFigure = new CAstericsFigure();
        public frmRhombus()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCAstericsFigure.ReadData(txtNum);
            ObjCAstericsFigure.GraphAstericsRhombus(lstFigure);
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
