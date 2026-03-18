using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string resultado = "";

            if (num % 2 == 0)
            {
                resultado = "EL NUMERO ES PAR";
            }
            else
            {
                resultado = "EL NUMERO ES IMPAR";
            }

            if (num % 3 == 0)
            {
                resultado = resultado + " Y ES DIVISIBLE POR 3";
            }
            else
            {
                resultado = resultado + " NO ES DIVISIBLE POR 3";
            }

            MessageBox.Show(resultado);

        }
    }
}
