using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcm.Clear();
            txtn.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double n;
            double resultado;
            resultado = 0;
            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n = Convert.ToDouble(txtn.Text);
                string unidad;
                unidad = comboBox1.SelectedItem.ToString();

                switch (unidad)
                {
                    case "Yardas":
                        resultado = n * 91.44;
                        break;
                    case "Pulgadas":
                        resultado = n * 2.54; 
                        break;
                    case "Pies":
                        resultado = n * 30.48; 
                        break;
                }

                txtcm.Text = resultado.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

