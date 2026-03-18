using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Triangulo
{
    public partial class Area_Triangulo : Form
    {
        public Area_Triangulo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);
            float valor2 = float.Parse(textBox2.Text);
            float valor3 = valor1 * valor2 / 2;

            textBox3.Text = valor3.ToString();
        }
    }
}
