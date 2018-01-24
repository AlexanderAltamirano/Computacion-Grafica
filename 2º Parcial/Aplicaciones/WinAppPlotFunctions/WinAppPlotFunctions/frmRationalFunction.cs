using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPlotFunctions
{
    public partial class frmRationalFunction : Form
    {
        CRationalFunction ObjectCRationalFunction = new CRationalFunction();
        public frmRationalFunction()
        {
            InitializeComponent();
        }

        private void frmRationalFunction_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectCRationalFunction.DrawAxis(picCanvas);
            ObjectCRationalFunction.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);
            ObjectCRationalFunction.DrawAsimptotes(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
