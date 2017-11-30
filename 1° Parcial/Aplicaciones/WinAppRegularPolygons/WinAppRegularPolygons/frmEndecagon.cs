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
    public partial class frmEndecagon : Form
    {
        CEndecagon objEndecagon = new CEndecagon();

        public frmEndecagon()
        {
            InitializeComponent();
        }

        private void frmEndecagon_Load(object sender, EventArgs e)
        {
            objEndecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEndecagon.ReadData(txtSide);
            objEndecagon.PerimeterEndecagon();
            objEndecagon.AreaEndecagon();
            objEndecagon.PrintData(txtPerimeter, txtArea);
            objEndecagon.GraphShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objEndecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close()
;        }
    }
}
