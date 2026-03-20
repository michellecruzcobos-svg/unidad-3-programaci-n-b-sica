using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;

            // Limpiar listas
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            while (x <= 10)
            {
                int x2 = x * x;
                int x3 = x * x * x;
                int z = x2 + x3;

                listBox1.Items.Add(x);
                listBox2.Items.Add(x2);
                listBox3.Items.Add(x3);
                listBox4.Items.Add(z);

                x++;
            }
        }
    }
}
