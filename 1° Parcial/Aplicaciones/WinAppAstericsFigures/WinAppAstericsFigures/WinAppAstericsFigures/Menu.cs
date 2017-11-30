using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmRumbuscs ObjFormc = new frmRumbuscs();
            ObjFormc.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            frmBranch ObjForm = new frmBranch();
            ObjForm.Show();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            frmFlag ObjForm = new frmFlag();
            ObjForm.Show();

        }

        private void btnTNumbers_Click(object sender, EventArgs e)
        {
            frmTNumbers ObjForm = new frmTNumbers();
            ObjForm.Show();
        }
    }
}
