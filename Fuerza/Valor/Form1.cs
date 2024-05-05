using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtacele.Clear();
            txtfuerza.Clear();
            txtmasa.Clear();
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btncalc_Click(object sender, EventArgs e)
        {
            int masa, acele;
            int fuerza;

            if(string.IsNullOrEmpty(txtacele.Text) || string.IsNullOrEmpty(txtmasa.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                masa = Convert.ToInt32(txtmasa.Text);
                acele = Convert.ToInt32(txtacele.Text);

                fuerza = masa * acele;
                txtfuerza.Text = fuerza.ToString();
            }
        }
    }
}