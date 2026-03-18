using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4.0 / 3.0 * pi * Math.Pow(radio1, 3);
            areaCirc.Text = area1.ToString();
            volumenCirc.Text = volumen1.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            radioCirc.Clear();
            areaCirc.Clear();
            volumenCirc.Clear();

            radioCirc.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double base1, altura1, area1;
            base1 = double.Parse(baseTri.Text);
            altura1 = double.Parse(alturaTri.Text);
            area1 = (base1 * altura1) / 2;
            areaTri.Text = area1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baseTri.Text = "";
            alturaTri.Text = "";
            areaTri.Text = "";

            baseTri.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double lado, area1, volumen1;
            lado = double.Parse(ladoCubo.Text);
            area1 = 6 * lado * lado;
            volumen1 = lado * lado * lado;
            areaCubo.Text = area1.ToString();
            volumenCubo.Text = volumen1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ladoCubo.Text = "";
            areaCubo.Text = "";
            volumenCubo.Text = "";

            ladoCubo.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio, altura, area1, volumen1;
            radio = double.Parse(radioCil.Text);
            altura = double.Parse(alturaCil.Text);
            area1 = 2 * pi * radio * (radio + altura);
            volumen1 = pi * radio * radio * altura;
            areaCil.Text = area1.ToString();
            volumenCil.Text = volumen1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            radioCil.Text = "";
            alturaCil.Text = "";
            areaCil.Text = "";
            volumenCil.Text = "";

            radioCil.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            double D, d, area1;
            D = double.Parse(dMayor.Text);
            d = double.Parse(dMenor.Text);
            area1 = (D * d) / 2;
            areaRombo.Text = area1.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            dMayor.Text = "";
            dMenor.Text = "";
            areaRombo.Text = "";

            dMayor.Focus();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double lado, area1, volumen1;
            lado = double.Parse(ladoOct.Text);
            area1 = 2 * Math.Sqrt(3) * lado * lado;
            volumen1 = (Math.Sqrt(2) / 3) * Math.Pow(lado, 3);
            areaOct.Text = area1.ToString();
            volumenOct.Text = volumen1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ladoOct.Text = "";
            areaOct.Text = "";
            volumenOct.Text = "";

            ladoOct.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
