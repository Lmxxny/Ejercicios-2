using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Orden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            double det;

            if (string.IsNullOrEmpty(txta.Text) || string.IsNullOrEmpty(txtb.Text) || string.IsNullOrEmpty(txtc.Text) || string.IsNullOrEmpty(txtd.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);

                if (a == 0)
                {
                    MessageBox.Show("No se puede evaluar la expresión para a = 0.", "Dato erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (b == 0)
                {
                    MessageBox.Show("No se puede evaluar la expresión para b = 0.", "Dato erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (c == 0)
                {
                    MessageBox.Show("No se puede evaluar la expresión para c = 0.", "Dato erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (d == 0)
                {
                    MessageBox.Show("No se puede evaluar la expresión para d = 0.", "Dato erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    det = (a * d) - (b * c);
                    txtdet.Text = det.ToString();
                }
            }
        }
    }
}
