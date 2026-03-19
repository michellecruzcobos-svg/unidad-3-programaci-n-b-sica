using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = Convert.ToInt32(textBox1.Text);

                if (edad < 12)
                {
                    textBox2.Text = "Niño";
                }
                else if (edad >= 12 && edad <= 17)
                {
                    textBox2.Text = "Adolescente";
                }
                else if (edad >= 18 && edad <= 60)
                {
                    textBox2.Text = "Adulto";
                }
                else if (edad > 60)
                {
                    textBox2.Text = "Tercera edad";
                }
            }
            catch
            {
                MessageBox.Show("Ingresa una edad válida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
