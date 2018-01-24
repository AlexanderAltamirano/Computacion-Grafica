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
    public partial class frmCuadraticFunction : Form
    {
        private CCuadraticFunction ObjectCCuadraticFunction = new CCuadraticFunction();

        public frmCuadraticFunction()
        {
            InitializeComponent();
        }

        private void frmCuadraticFunction_Load(object sender, EventArgs e)
        {
            ObjectCCuadraticFunction.InitializeData();
            ObjectCCuadraticFunction.InitializeControls(txtA, txtB, txtC, 
                                                        picCanvas, lstX, 
                                                        lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectCCuadraticFunction.ReadData(txtA, txtB, txtC);
            ObjectCCuadraticFunction.DrawAxis(picCanvas);
            ObjectCCuadraticFunction.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjectCCuadraticFunction.InitializeData();
            ObjectCCuadraticFunction.InitializeControls(txtA, txtB, txtC,
                                                        picCanvas, lstX,
                                                        lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
