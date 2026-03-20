using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Limpiar la lista antes de mostrar nuevos resultados
            listBox1.Items.Clear();

            // 2. Obtener los valores de los TextBox
            // textBox1: El número de la tabla
            // textBox2: El límite hasta donde llegará
            int tabla = int.Parse(textBox1.Text);
            int limite = int.Parse(textBox2.Text);

            // 3. Inicializar el contador
            int contador = 1;

            // 4. Estructura DO-WHILE
            do
            {
                // Calcular el resultado de la línea actual
                int resultado = tabla * contador;

                // Formatear el texto y agregarlo al listBox1
                listBox1.Items.Add(tabla + " * " + contador + " = " + resultado);

                // Incrementar el contador en 1
                contador++;
            }
            while (contador <= limite); // La condición se evalúa al final
        }
    }
}
