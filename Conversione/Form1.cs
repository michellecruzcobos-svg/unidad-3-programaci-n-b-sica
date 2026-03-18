using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversione
{
    public partial class Conversiones : Form
    {
        public Conversiones()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit;
            celsius = Convert.ToDouble(txtValor.Text);
            fahrenheit = (celsius * 9 / 5) + 32;
            txtResultado.Text = fahrenheit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fahrenheit, celsius;
            fahrenheit = Convert.ToDouble(txtValor.Text);
            celsius = (fahrenheit - 32) * 5 / 9;
            txtResultado.Text = celsius.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtResultado.Clear();
            txtValor.Focus();
        }
    }
}
