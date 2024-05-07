using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtpoi.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {

            int n;
            String poi;

            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n = Convert.ToInt32(txtn.Text);

                if (n % 2 == 0)
                {
                    poi = "Par";
                    txtpoi.Text = poi.ToString();
                }
                else
                {
                    poi = "Impar";
                    txtpoi.Text = poi.ToString();
                }
            }
        }
    }
}
