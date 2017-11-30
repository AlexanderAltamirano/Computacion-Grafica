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
    public partial class frmRectangle : Form
    {

        private CRectangle ObjRectangle = new CRectangle();

        

        public frmRectangle()
        {
            InitializeComponent();

        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRectangle.ReadData(txtSideHeight, txtSideWidth);
            ObjRectangle.AreaRectangle();
            ObjRectangle.PerimeterRectangle();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            ObjRectangle.DrawShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtSideHeight,txtSideWidth,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
