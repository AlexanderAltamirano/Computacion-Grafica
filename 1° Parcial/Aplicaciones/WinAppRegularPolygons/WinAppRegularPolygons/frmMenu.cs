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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmEquilaterTriangle ObjForm = new frmEquilaterTriangle();
            ObjForm.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare objForm = new frmSquare();
            objForm.Show();
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            frmPentagon ObjForm = new frmPentagon();
            ObjForm.Show();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            frmHexagon ObjForm = new frmHexagon();
            ObjForm.Show();
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            frmHeptagon ObjForm = new frmHeptagon();
            ObjForm.Show();
        }

        private void btnOctagon_Click(object sender, EventArgs e)
        {
            frmOctagon ObjForm = new frmOctagon();
            ObjForm.Show();
        }

        private void btnDecagon_Click(object sender, EventArgs e)
        {
            frmDecagon ObjForm = new frmDecagon();
            ObjForm.Show();
        }

        private void btnDodecagon_Click(object sender, EventArgs e)
        {
            frmDodecagon ObjForm = new frmDodecagon();
            ObjForm.Show();
        }


        private void btnEneagon_Click(object sender, EventArgs e)
        {
            frmEneagon objForm = new frmEneagon();
            objForm.Show();
        }

        private void btnEndecagon_Click(object sender, EventArgs e)
        {
            frmEndecagon objForm = new frmEndecagon();
            objForm.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
