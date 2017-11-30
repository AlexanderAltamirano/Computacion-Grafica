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
    public partial class frmTriangle : Form
    {
        private CTriangle ObjTriangle = new CTriangle();

        public frmTriangle()
        {
            InitializeComponent();
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            ObjTriangle.SemiperimeterTriangle();
            ObjTriangle.PerimeterTriangle();
            ObjTriangle.AreaTriangle();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
            ObjTriangle.DrawShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSideA, txtSideB, txtSideC,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
