using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLimasonSinLaso
{
    public partial class Limason : Form
    {
        private CLimasonsinLazo ObLimason = new CLimasonsinLazo();
        public Limason()
        {
            InitializeComponent();
        }

        private void grbExpresion_Enter(object sender, EventArgs e)
        {

        }

        private void lstX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limason_Load(object sender, EventArgs e)
        {
            ObLimason.InitializeData();
            ObLimason.InitializeControls(txtA, txtB, picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObLimason.ReadData(txtA,txtB);
            ObLimason.DrawAxis(picCanvas);
            ObLimason.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);
            ObLimason.Analice(txtEvalua);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObLimason.InitializeData();
            txtEvalua.Text = "";
            ObLimason.InitializeControls(txtA, txtB, picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
