using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Agregamos el número escrito a la lista
            listBox1.Items.Add(textBox1.Text);

            // Convertimos el texto a número decimal
            f_num = float.Parse(textBox1.Text);

            // Lo sumamos al acumulador global
            Total += f_num;

            // Limpiamos y preparamos para el siguiente número
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostramos la suma total acumulada
            textBox2.Text = Total.ToString();
        }
    }
}
