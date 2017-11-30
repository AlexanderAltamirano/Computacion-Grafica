using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    public partial class frmSquare : Form
    {

        private CSquare ObjSquare = new CSquare();

        public frmSquare()
        {
            InitializeComponent();
        }

        private void frmSquart_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSideA);
            ObjSquare.AreaSquare();
            ObjSquare.PerimeterSquare();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.DrawShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSideA,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
