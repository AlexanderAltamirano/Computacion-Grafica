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
    public partial class frmHexagon : Form
    {
        // Datos miembro - atributos.
        private CHexagon ObjCHexagon = new CHexagon();

        // Constructor del formulario.
        public frmHexagon()
        {
            InitializeComponent();
            ObjCHexagon.InitializeData(txtSide,txtPerimeter,txtArea,picCanvas);
        }
        private void frmHexagon_Load(object sender, EventArgs e)
        {
            ObjCHexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCHexagon.ReadData(txtSide);
            ObjCHexagon.PerimeterHexagon();
            ObjCHexagon.ApothemHexagon();
            ObjCHexagon.AreaHexagon();
            ObjCHexagon.PrintData(txtArea, txtPerimeter);
            ObjCHexagon.GraphShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCHexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
