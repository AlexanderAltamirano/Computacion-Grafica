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
    
    public partial class frmSquare : Form
    {
        CSquare objSquare = new CSquare();

        public frmSquare()
        {
            InitializeComponent();
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {
            objSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSquare.ReadData(txtSide);
            objSquare.PerimeterSquare();
            objSquare.AreaSquare();
            objSquare.PrintData(txtPerimeter, txtArea);
            objSquare.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
