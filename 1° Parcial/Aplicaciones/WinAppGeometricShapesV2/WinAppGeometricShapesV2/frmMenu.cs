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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSquart_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle ObjForm = new frmCircle();
            ObjForm.Show();
        }

        private void btnRectrangle_Click(object sender, EventArgs e)
        {
            frmRectangle ObjForm = new frmRectangle();
            ObjForm.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cerrar aplicacion
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
