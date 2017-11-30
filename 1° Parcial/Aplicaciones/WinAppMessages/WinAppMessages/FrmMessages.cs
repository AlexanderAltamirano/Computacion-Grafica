using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMessages
{
    public partial class FrmMessages : Form
    {
        public FrmMessages()
        {
            InitializeComponent();
        }
        private void FrmMessages_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo!!");
        }

        private void btnMessage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp","Mensaje de control");
        }

        private void btnMessage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp", "Mensaje de control",
                MessageBoxButtons.AbortRetryIgnore, 
                MessageBoxIcon.Information);
        }

        private void btnMessage3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp", "Mensaje de control",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
