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
    public partial class frmDecagon : Form
    {
        private CDecagon ObjCDecagon = new CDecagon();
        public frmDecagon()
        {
            InitializeComponent();
            ObjCDecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCDecagon.ReadData(txtSide);
            ObjCDecagon.PerimeterHeptagon();
            ObjCDecagon.ApothemHeptagon();
            ObjCDecagon.AreaHeptagon();
            ObjCDecagon.PrintData( txtPerimeter, txtArea);
            ObjCDecagon.GraphShape(picCanvas);
        }

        private void frmDecagon_Load(object sender, EventArgs e)
        {
            ObjCDecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCDecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
