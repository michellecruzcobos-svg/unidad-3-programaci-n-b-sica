using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double c1 = Convert.ToDouble(textBox1.Text);
                double c2 = Convert.ToDouble(textBox2.Text);
                double c3 = Convert.ToDouble(textBox3.Text);
                double c4 = Convert.ToDouble(textBox4.Text);

                double promedio = (c1 + c2 + c3 + c4) / 4;

                if (promedio >= 6)
                {
                    label1.Text = "Promedio: " + promedio.ToString("0.00") + " - APROBADO";
                }
                else
                {
                    label1.Text = "Promedio: " + promedio.ToString("0.00") + " - REPROBADO";
                }
            }
            catch
            {
                MessageBox.Show("Ingresa solo números");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            label1.Text = "";
        }
    }
}