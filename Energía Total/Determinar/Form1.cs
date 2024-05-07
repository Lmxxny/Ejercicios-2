using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Determinar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtmasa.Clear();
            txtvelo.Clear();
            txtenercin.Clear();
            txtenerpot.Clear();
            txtenertot.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double masa, velocidad, altura, enercin, enerpot, enertot;
            double graved = 9.8;

            if (string.IsNullOrEmpty(txtaltura.Text) || string.IsNullOrEmpty(txtmasa.Text) || string.IsNullOrEmpty(txtvelo.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                masa = Convert.ToDouble(txtmasa.Text);
                velocidad = Convert.ToDouble(txtvelo.Text);
                altura = Convert.ToDouble(txtaltura.Text);

                enercin = 0.5 * masa * Math.Pow(velocidad, 2);
                txtenercin.Text = enercin.ToString();

                enerpot = masa * graved * altura;
                txtenerpot.Text = enerpot.ToString();

                enertot = enercin + enerpot;
                txtenertot.Text = enertot.ToString();
            }
        }
    }
}
