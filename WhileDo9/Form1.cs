using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            if (int.TryParse(textBox1.Text, out num))
            {
                if (num < 0)
                {
                    MessageBox.Show("No hay factorial de negativos");
                    return;
                }

                listBox1.Items.Clear();

                int factorial = 1;
                int i = num;

                // repetir valor en textbox2
                textBox2.Text = num.ToString();

                while (i >= 1)
                {
                    listBox1.Items.Add(i);
                    factorial = factorial * i;
                    i--;
                }

                textBox3.Text = factorial.ToString();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido");
            }
        }
    }
}
