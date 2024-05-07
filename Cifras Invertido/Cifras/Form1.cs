using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcifra.Clear();
            txtinvertido.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int cifra;
            int invertido;

            if (string.IsNullOrEmpty(txtcifra.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cifra = Convert.ToInt32(txtcifra.Text);

                if ( cifra <= 99 )
                {
                    MessageBox.Show("Por favor, ingresa un valor de tres cifras", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }else if (cifra >= 1000)
                {
                    MessageBox.Show("Por favor, ingresa un valor de tres cifras", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    int centenas = cifra / 100;
                    int decenas = (cifra % 100) / 10;
                    int unidades = cifra % 10;

                    invertido = (unidades * 100) + (decenas * 10) + centenas;

                    txtinvertido.Text = invertido.ToString();
                }
                }
            }
        }
    }
