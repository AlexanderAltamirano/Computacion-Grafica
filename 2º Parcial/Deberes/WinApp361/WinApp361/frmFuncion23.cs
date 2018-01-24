using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp361
{
    public partial class frmFuncion23 : Form
    {
        CParametricFunction3 ObjectCParametricFunction = new CParametricFunction3();
        public frmFuncion23()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectCParametricFunction.DrawAxis(picCanvas);
            ObjectCParametricFunction.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }
    }
}
