using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
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
            txte.Clear();
            txtf.Clear();
            txtx.Clear();
            txty.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double a, b, c, d, ee, f;

            if (string.IsNullOrWhiteSpace(txta.Text) || string.IsNullOrEmpty(txtb.Text) || string.IsNullOrEmpty(txtc.Text) || string.IsNullOrEmpty(txtd.Text) || string.IsNullOrEmpty(txte.Text) || string.IsNullOrEmpty(txtf.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);
                ee = Convert.ToDouble(txte.Text);
                f = Convert.ToDouble(txtf.Text);

                double det;
                double detX;
                double detY;

                det = a * ee - b * d;
                detX = c * ee - b * f;
                detY = a * f - c * d;

                if (det != 0)
                {
                    // Calcular las soluciones
                    double x = detX / det;
                    double y = detY / det;
                    txtx.Text = x.ToString();
                    txty.Text = y.ToString();
                }
                else
                {
                    if (detX == 0 && detY == 0)
                    {
                        MessageBox.Show("El sistema tiene infinitas soluciones.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("El sistema no tiene solución.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}