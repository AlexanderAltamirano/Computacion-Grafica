using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    public partial class frmEneagon : Form
    {
        CEneagon objEneagon = new CEneagon();

        public frmEneagon()
        {
            InitializeComponent();
        }

        private void frmEneagon_Load(object sender, EventArgs e)
        {
            objEneagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            objEneagon.ReadData(txtSide);
            objEneagon.PerimeterEneagon();
            objEneagon.AreaEneagon();
            objEneagon.PrintData(txtPerimeter, txtArea);
            objEneagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objEneagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
