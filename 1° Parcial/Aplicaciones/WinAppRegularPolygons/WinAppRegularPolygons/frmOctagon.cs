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
    public partial class frmOctagon : Form
    {
        // Datos miembro - Atributos.
        COctagon ObjOctagon = new COctagon();

        public frmOctagon()
        {
            InitializeComponent();
            ObjOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void frmOctagon_Load(object sender, EventArgs e)
        {
            ObjOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjOctagon.ReadData(txtSide);
            ObjOctagon.PerimeterHexagon();
            ObjOctagon.AreaHexagon();
            ObjOctagon.PrintData(txtPerimeter, txtArea);
            ObjOctagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
