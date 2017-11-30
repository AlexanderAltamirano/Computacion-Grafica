using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircle
{
    public partial class frmCircle : Form
    {
        //Datos miebro - Atributos de la clase.

        private float mRadius, mPerimeter, mArea;

        //Funciones miembro - Metodo de clase.
        
        //Constructor de la clase.
        
        public frmCircle()
        {

            InitializeComponent();
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; 

        }

        private void ReadData()
        {

            try
            {
                mRadius = float.Parse(txtRadius.Text);  
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void PerimeterCircle()
        {

            mPerimeter = 2 * (float)Math.PI*mRadius;

        }

        private void AreaCircle()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = (float)Math.PI * (float)Math.Pow(mRadius,2);

        }

        private void PrintData()
        {

            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        
        }

        private void InitializeData()
        {

            txtRadius.Focus();
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtRadius.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";


        }

        private void frmCircle_Load(object sender, EventArgs e)
        {

            InitializeData();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ReadData();
            PerimeterCircle();
            AreaCircle();
            PrintData();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            InitializeData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
