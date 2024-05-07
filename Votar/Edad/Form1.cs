using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtedad.Clear();
            txtvotar.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int edad;
            String votar;

            if (string.IsNullOrEmpty(txtedad.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                edad = Convert.ToInt32(txtedad.Text);

                if (edad < 16)
                {
                    votar = "No puede votar";
                    txtvotar.Text = votar.ToString();
                }
                else
                {
                    votar = "Puede votar";
                    txtvotar.Text = votar.ToString();
                }
            }
        }
    }
}
