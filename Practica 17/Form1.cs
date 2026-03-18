using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            int mayor, medio, menor;

            if (a >= b && a >= c)
            {
                mayor = a;
                if (b >= c)
                {
                    medio = b;
                    menor = c;
                }
                else
                {
                    medio = c;
                    menor = b;
                }
            }
            else if (b >= a && b >= c)
            {
                mayor = b;
                if (a >= c)
                {
                    medio = a;
                    menor = c;
                }
                else
                {
                    medio = c;
                    menor = a;
                }
            }
            else
            {
                mayor = c;
                if (a >= b)
                {
                    medio = a;
                    menor = b;
                }
                else
                {
                    medio = b;
                    menor = a;
                }
            }

            textBox4.Text = mayor.ToString();
            textBox5.Text = medio.ToString();
            textBox6.Text = menor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
