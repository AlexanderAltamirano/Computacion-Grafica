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
        // Datos miembro - Atributos.
        CHexagon ObjHexagon = new CHexagon();

        public frmHexagon()
        {
            InitializeComponent();
            ObjHexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjHexagon.ReadData(txtSide);
            ObjHexagon.PerimeterHexagon();
            ObjHexagon.AreaHexagon();
            ObjHexagon.PrintData(txtPerimeter, txtArea);
            ObjHexagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
