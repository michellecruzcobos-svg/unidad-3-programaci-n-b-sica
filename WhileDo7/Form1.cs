using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inferior = 0, superior = 0;

            // Validar números
            if (!int.TryParse(textBox1.Text, out inferior) ||
                !int.TryParse(textBox2.Text, out superior))
            {
                MessageBox.Show("Ingresa números válidos");
                return;
            }

            // Validar rango
            if (inferior > superior)
            {
                MessageBox.Show("El rango inferior no puede ser mayor");
                return;
            }

            listBox1.Items.Clear();

            int suma = 0;
            int i = inferior;

            while (i <= superior)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
                i = i + 1;
            }

            textBox3.Text = suma.ToString();
        }
    }
}
