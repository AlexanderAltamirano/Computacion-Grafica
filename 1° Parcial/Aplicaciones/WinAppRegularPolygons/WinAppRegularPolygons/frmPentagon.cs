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
    public partial class frmPentagon : Form
    {
        // Datos miembro - atributos.

        private CPentagon ObjCPentagon = new CPentagon();

        // Constructor del formulario.
        public frmPentagon()
        {
            InitializeComponent();
            ObjCPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void frmPentagon_Load(object sender, EventArgs e)
        {
            ObjCPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCPentagon.ReadData(txtSide);
            ObjCPentagon.PerimeterPentagon();
            ObjCPentagon.ApothemPentagon();
            ObjCPentagon.AreaPentagon();
            ObjCPentagon.PrintData(txtArea, txtPerimeter);
            ObjCPentagon.GraphShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
