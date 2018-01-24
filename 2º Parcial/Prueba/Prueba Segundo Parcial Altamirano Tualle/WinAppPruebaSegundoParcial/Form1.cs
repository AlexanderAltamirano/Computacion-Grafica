using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPruebaSegundoParcial
{
    public partial class Form1 : Form
    {

        private CArrayEncriptacion A = new CArrayEncriptacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBinarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstBinarios.Items.Clear();
            lstDesencriptacion.Items.Clear();
            txtCedula.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            A.EncriptarCedula(txtCedula, lstBinarios);
        }

        private void btnDesencriptacion_Click(object sender, EventArgs e)
        {
            A.DesencriptarCedula(lstBinarios,lstDesencriptacion);
        }
    }
}
