using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dowhile1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;

            listBox1.Items.Clear(); // Opcional: limpia antes de volver a listar

            do
            {
                listBox1.Items.Add(x);
                x++;
            }
            while (x <= 10);
        }
    }
}
