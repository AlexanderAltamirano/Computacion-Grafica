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
    public partial class frmHeptagon : Form
    {
        // Datos miembro - atributos.

        private CHeptagon ObjCHeptagon = new CHeptagon();

        // Constructor del formulario.
        public frmHeptagon()
        {
            InitializeComponent();
            ObjCHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void frmHeptagon_Load(object sender, EventArgs e)
        {
            ObjCHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCHeptagon.ReadData(txtSide);
            ObjCHeptagon.PerimeterHeptagon();
            ObjCHeptagon.ApothemHeptagon();
            ObjCHeptagon.AreaHeptagon();
            ObjCHeptagon.PrintData(txtArea, txtPerimeter);
            ObjCHeptagon.GraphShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
