using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            if (int.TryParse(textBox1.Text, out num))
            {
                if (num % 2 == 0)
                {
                    listBox1.Items.Add(num + " Par");
                }
                else
                {
                    listBox1.Items.Add(num + " Impar");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número válido");
            }

            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
