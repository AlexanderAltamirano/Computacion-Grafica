using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2AltamiranoTualle
{
    public partial class frmEncriptar : Form
    {
        CArrayEncryptacion encrypt = new CArrayEncryptacion();

        public frmEncriptar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encrypt.EncrypCedula(txtCedula, lstEncrypt, lstProcess);
            //encrypt.Process(txtCedula, lstProcess);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstEncrypt.Items.Clear();
            lstProcess.Items.Clear();
            txtCedula.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
