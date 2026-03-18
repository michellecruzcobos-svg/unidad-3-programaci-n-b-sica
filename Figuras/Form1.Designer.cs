namespace Figuras
{
    partial class Figuras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Circunferencia = new System.Windows.Forms.TabPage();
            this.Triangulo = new System.Windows.Forms.TabPage();
            this.Cubo = new System.Windows.Forms.TabPage();
            this.Cilindro = new System.Windows.Forms.TabPage();
            this.Rombo = new System.Windows.Forms.TabPage();
            this.Octaedro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioCirc = new System.Windows.Forms.TextBox();
            this.areaCirc = new System.Windows.Forms.TextBox();
            this.volumenCirc = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.areaTri = new System.Windows.Forms.TextBox();
            this.alturaTri = new System.Windows.Forms.TextBox();
            this.baseTri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.areaCubo = new System.Windows.Forms.TextBox();
            this.volumenCubo = new System.Windows.Forms.TextBox();
            this.ladoCubo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.areaCil = new System.Windows.Forms.TextBox();
            this.volumenCil = new System.Windows.Forms.TextBox();
            this.alturaCil = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioCil = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dMenor = new System.Windows.Forms.TextBox();
            this.dMayor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.areaRombo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.volumenOct = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.areaOct = new System.Windows.Forms.TextBox();
            this.ladoOct = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Circunferencia.SuspendLayout();
            this.Triangulo.SuspendLayout();
            this.Cubo.SuspendLayout();
            this.Cilindro.SuspendLayout();
            this.Rombo.SuspendLayout();
            this.Octaedro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Circunferencia);
            this.tabControl1.Controls.Add(this.Triangulo);
            this.tabControl1.Controls.Add(this.Cubo);
            this.tabControl1.Controls.Add(this.Cilindro);
            this.tabControl1.Controls.Add(this.Rombo);
            this.tabControl1.Controls.Add(this.Octaedro);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // Circunferencia
            // 
            this.Circunferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Circunferencia.Controls.Add(this.btnSalir);
            this.Circunferencia.Controls.Add(this.btnBorrar);
            this.Circunferencia.Controls.Add(this.btnCalcular);
            this.Circunferencia.Controls.Add(this.volumenCirc);
            this.Circunferencia.Controls.Add(this.areaCirc);
            this.Circunferencia.Controls.Add(this.radioCirc);
            this.Circunferencia.Controls.Add(this.label5);
            this.Circunferencia.Controls.Add(this.label3);
            this.Circunferencia.Controls.Add(this.label1);
            this.Circunferencia.Controls.Add(this.label2);
            this.Circunferencia.Controls.Add(this.label4);
            this.Circunferencia.Location = new System.Drawing.Point(4, 25);
            this.Circunferencia.Name = "Circunferencia";
            this.Circunferencia.Padding = new System.Windows.Forms.Padding(3);
            this.Circunferencia.Size = new System.Drawing.Size(794, 425);
            this.Circunferencia.TabIndex = 0;
            this.Circunferencia.Text = "Circunferencia";
            // 
            // Triangulo
            // 
            this.Triangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Triangulo.Controls.Add(this.button1);
            this.Triangulo.Controls.Add(this.button2);
            this.Triangulo.Controls.Add(this.button3);
            this.Triangulo.Controls.Add(this.areaTri);
            this.Triangulo.Controls.Add(this.alturaTri);
            this.Triangulo.Controls.Add(this.baseTri);
            this.Triangulo.Controls.Add(this.label6);
            this.Triangulo.Controls.Add(this.label7);
            this.Triangulo.Controls.Add(this.label8);
            this.Triangulo.Controls.Add(this.label9);
            this.Triangulo.Location = new System.Drawing.Point(4, 25);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Padding = new System.Windows.Forms.Padding(3);
            this.Triangulo.Size = new System.Drawing.Size(794, 425);
            this.Triangulo.TabIndex = 1;
            this.Triangulo.Text = "Triangulo";
            // 
            // Cubo
            // 
            this.Cubo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cubo.Controls.Add(this.button4);
            this.Cubo.Controls.Add(this.button5);
            this.Cubo.Controls.Add(this.button6);
            this.Cubo.Controls.Add(this.areaCubo);
            this.Cubo.Controls.Add(this.volumenCubo);
            this.Cubo.Controls.Add(this.ladoCubo);
            this.Cubo.Controls.Add(this.label10);
            this.Cubo.Controls.Add(this.label11);
            this.Cubo.Controls.Add(this.label12);
            this.Cubo.Controls.Add(this.label13);
            this.Cubo.Location = new System.Drawing.Point(4, 25);
            this.Cubo.Name = "Cubo";
            this.Cubo.Size = new System.Drawing.Size(794, 425);
            this.Cubo.TabIndex = 2;
            this.Cubo.Text = "Cubo";
            // 
            // Cilindro
            // 
            this.Cilindro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cilindro.Controls.Add(this.radioCil);
            this.Cilindro.Controls.Add(this.label18);
            this.Cilindro.Controls.Add(this.button7);
            this.Cilindro.Controls.Add(this.button8);
            this.Cilindro.Controls.Add(this.button9);
            this.Cilindro.Controls.Add(this.areaCil);
            this.Cilindro.Controls.Add(this.volumenCil);
            this.Cilindro.Controls.Add(this.alturaCil);
            this.Cilindro.Controls.Add(this.label14);
            this.Cilindro.Controls.Add(this.label15);
            this.Cilindro.Controls.Add(this.label16);
            this.Cilindro.Controls.Add(this.label17);
            this.Cilindro.Location = new System.Drawing.Point(4, 25);
            this.Cilindro.Name = "Cilindro";
            this.Cilindro.Size = new System.Drawing.Size(794, 425);
            this.Cilindro.TabIndex = 3;
            this.Cilindro.Text = "Cilindro";
            // 
            // Rombo
            // 
            this.Rombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Rombo.Controls.Add(this.areaRombo);
            this.Rombo.Controls.Add(this.label19);
            this.Rombo.Controls.Add(this.button10);
            this.Rombo.Controls.Add(this.button11);
            this.Rombo.Controls.Add(this.button12);
            this.Rombo.Controls.Add(this.dMenor);
            this.Rombo.Controls.Add(this.dMayor);
            this.Rombo.Controls.Add(this.label21);
            this.Rombo.Controls.Add(this.label22);
            this.Rombo.Controls.Add(this.label23);
            this.Rombo.Location = new System.Drawing.Point(4, 25);
            this.Rombo.Name = "Rombo";
            this.Rombo.Size = new System.Drawing.Size(794, 425);
            this.Rombo.TabIndex = 4;
            this.Rombo.Text = "Rombo";
            // 
            // Octaedro
            // 
            this.Octaedro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Octaedro.Controls.Add(this.volumenOct);
            this.Octaedro.Controls.Add(this.label20);
            this.Octaedro.Controls.Add(this.button13);
            this.Octaedro.Controls.Add(this.button14);
            this.Octaedro.Controls.Add(this.button15);
            this.Octaedro.Controls.Add(this.areaOct);
            this.Octaedro.Controls.Add(this.ladoOct);
            this.Octaedro.Controls.Add(this.label24);
            this.Octaedro.Controls.Add(this.label25);
            this.Octaedro.Controls.Add(this.label26);
            this.Octaedro.Location = new System.Drawing.Point(4, 25);
            this.Octaedro.Name = "Octaedro";
            this.Octaedro.Size = new System.Drawing.Size(794, 425);
            this.Octaedro.TabIndex = 5;
            this.Octaedro.Text = "Octaedro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Circunferencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Volumen";
            // 
            // radioCirc
            // 
            this.radioCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCirc.Location = new System.Drawing.Point(242, 140);
            this.radioCirc.Name = "radioCirc";
            this.radioCirc.Size = new System.Drawing.Size(100, 28);
            this.radioCirc.TabIndex = 7;
            // 
            // areaCirc
            // 
            this.areaCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCirc.Location = new System.Drawing.Point(242, 208);
            this.areaCirc.Name = "areaCirc";
            this.areaCirc.Size = new System.Drawing.Size(100, 28);
            this.areaCirc.TabIndex = 8;
            // 
            // volumenCirc
            // 
            this.volumenCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumenCirc.Location = new System.Drawing.Point(542, 209);
            this.volumenCirc.Name = "volumenCirc";
            this.volumenCirc.Size = new System.Drawing.Size(100, 28);
            this.volumenCirc.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(86, 304);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 37);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(333, 304);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 37);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(576, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 37);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(323, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(76, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // areaTri
            // 
            this.areaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTri.Location = new System.Drawing.Point(532, 200);
            this.areaTri.Name = "areaTri";
            this.areaTri.Size = new System.Drawing.Size(100, 28);
            this.areaTri.TabIndex = 19;
            // 
            // alturaTri
            // 
            this.alturaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaTri.Location = new System.Drawing.Point(232, 199);
            this.alturaTri.Name = "alturaTri";
            this.alturaTri.Size = new System.Drawing.Size(100, 28);
            this.alturaTri.TabIndex = 18;
            // 
            // baseTri
            // 
            this.baseTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTri.Location = new System.Drawing.Point(232, 131);
            this.baseTri.Name = "baseTri";
            this.baseTri.Size = new System.Drawing.Size(100, 28);
            this.baseTri.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Altura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Base";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Triangulo";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(578, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 37);
            this.button4.TabIndex = 32;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(335, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 37);
            this.button5.TabIndex = 31;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(88, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 37);
            this.button6.TabIndex = 30;
            this.button6.Text = "Calcular";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // areaCubo
            // 
            this.areaCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCubo.Location = new System.Drawing.Point(544, 223);
            this.areaCubo.Name = "areaCubo";
            this.areaCubo.Size = new System.Drawing.Size(100, 28);
            this.areaCubo.TabIndex = 29;
            // 
            // volumenCubo
            // 
            this.volumenCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumenCubo.Location = new System.Drawing.Point(244, 222);
            this.volumenCubo.Name = "volumenCubo";
            this.volumenCubo.Size = new System.Drawing.Size(100, 28);
            this.volumenCubo.TabIndex = 28;
            // 
            // ladoCubo
            // 
            this.ladoCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoCubo.Location = new System.Drawing.Point(244, 154);
            this.ladoCubo.Name = "ladoCubo";
            this.ladoCubo.Size = new System.Drawing.Size(100, 28);
            this.ladoCubo.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Volumen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Cubo";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(578, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 37);
            this.button7.TabIndex = 42;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(335, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 37);
            this.button8.TabIndex = 41;
            this.button8.Text = "Borrar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(88, 331);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 37);
            this.button9.TabIndex = 40;
            this.button9.Text = "Calcular";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // areaCil
            // 
            this.areaCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCil.Location = new System.Drawing.Point(508, 236);
            this.areaCil.Name = "areaCil";
            this.areaCil.Size = new System.Drawing.Size(100, 28);
            this.areaCil.TabIndex = 39;
            // 
            // volumenCil
            // 
            this.volumenCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumenCil.Location = new System.Drawing.Point(244, 235);
            this.volumenCil.Name = "volumenCil";
            this.volumenCil.Size = new System.Drawing.Size(100, 28);
            this.volumenCil.TabIndex = 38;
            // 
            // alturaCil
            // 
            this.alturaCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaCil.Location = new System.Drawing.Point(244, 167);
            this.alturaCil.Name = "alturaCil";
            this.alturaCil.Size = new System.Drawing.Size(100, 28);
            this.alturaCil.TabIndex = 37;
            this.alturaCil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(419, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 36;
            this.label14.Text = "Area";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(140, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "Volumen";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(149, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 25);
            this.label16.TabIndex = 34;
            this.label16.Text = "Altura";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(343, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 33;
            this.label17.Text = "Cilindro";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // radioCil
            // 
            this.radioCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCil.Location = new System.Drawing.Point(508, 167);
            this.radioCil.Name = "radioCil";
            this.radioCil.Size = new System.Drawing.Size(100, 28);
            this.radioCil.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(413, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 25);
            this.label18.TabIndex = 43;
            this.label18.Text = "Radio";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(578, 331);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 37);
            this.button10.TabIndex = 54;
            this.button10.Text = "Salir";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(335, 331);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(128, 37);
            this.button11.TabIndex = 53;
            this.button11.Text = "Borrar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(88, 331);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 37);
            this.button12.TabIndex = 52;
            this.button12.Text = "Calcular";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // dMenor
            // 
            this.dMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dMenor.Location = new System.Drawing.Point(313, 181);
            this.dMenor.Name = "dMenor";
            this.dMenor.Size = new System.Drawing.Size(150, 28);
            this.dMenor.TabIndex = 50;
            // 
            // dMayor
            // 
            this.dMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dMayor.Location = new System.Drawing.Point(313, 113);
            this.dMayor.Name = "dMayor";
            this.dMayor.Size = new System.Drawing.Size(150, 28);
            this.dMayor.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(74, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 25);
            this.label21.TabIndex = 47;
            this.label21.Text = "Diagonal Menor";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(83, 113);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(163, 25);
            this.label22.TabIndex = 46;
            this.label22.Text = "Diagonal Mayor";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(343, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 25);
            this.label23.TabIndex = 45;
            this.label23.Text = "Rombo";
            // 
            // areaRombo
            // 
            this.areaRombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaRombo.Location = new System.Drawing.Point(313, 256);
            this.areaRombo.Name = "areaRombo";
            this.areaRombo.Size = new System.Drawing.Size(150, 28);
            this.areaRombo.TabIndex = 56;
            this.areaRombo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(83, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 25);
            this.label19.TabIndex = 55;
            this.label19.Text = "Area";
            // 
            // volumenOct
            // 
            this.volumenOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumenOct.Location = new System.Drawing.Point(320, 256);
            this.volumenOct.Name = "volumenOct";
            this.volumenOct.Size = new System.Drawing.Size(150, 28);
            this.volumenOct.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(90, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 25);
            this.label20.TabIndex = 65;
            this.label20.Text = "Volumen";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(585, 331);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(128, 37);
            this.button13.TabIndex = 64;
            this.button13.Text = "Salir";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(342, 331);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(128, 37);
            this.button14.TabIndex = 63;
            this.button14.Text = "Borrar";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(95, 331);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(128, 37);
            this.button15.TabIndex = 62;
            this.button15.Text = "Calcular";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // areaOct
            // 
            this.areaOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaOct.Location = new System.Drawing.Point(320, 181);
            this.areaOct.Name = "areaOct";
            this.areaOct.Size = new System.Drawing.Size(150, 28);
            this.areaOct.TabIndex = 61;
            // 
            // ladoOct
            // 
            this.ladoOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoOct.Location = new System.Drawing.Point(320, 113);
            this.ladoOct.Name = "ladoOct";
            this.ladoOct.Size = new System.Drawing.Size(150, 28);
            this.ladoOct.TabIndex = 60;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(90, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 25);
            this.label24.TabIndex = 59;
            this.label24.Text = "Area";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(90, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 25);
            this.label25.TabIndex = 58;
            this.label25.Text = "Lado";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(350, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 25);
            this.label26.TabIndex = 57;
            this.label26.Text = "Octaedro";
            // 
            // Figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Figuras";
            this.Text = "Figuras";
            this.tabControl1.ResumeLayout(false);
            this.Circunferencia.ResumeLayout(false);
            this.Circunferencia.PerformLayout();
            this.Triangulo.ResumeLayout(false);
            this.Triangulo.PerformLayout();
            this.Cubo.ResumeLayout(false);
            this.Cubo.PerformLayout();
            this.Cilindro.ResumeLayout(false);
            this.Cilindro.PerformLayout();
            this.Rombo.ResumeLayout(false);
            this.Rombo.PerformLayout();
            this.Octaedro.ResumeLayout(false);
            this.Octaedro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Circunferencia;
        private System.Windows.Forms.TabPage Triangulo;
        private System.Windows.Forms.TabPage Cubo;
        private System.Windows.Forms.TabPage Cilindro;
        private System.Windows.Forms.TabPage Rombo;
        private System.Windows.Forms.TabPage Octaedro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox volumenCirc;
        private System.Windows.Forms.TextBox areaCirc;
        private System.Windows.Forms.TextBox radioCirc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox areaTri;
        private System.Windows.Forms.TextBox alturaTri;
        private System.Windows.Forms.TextBox baseTri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox areaCubo;
        private System.Windows.Forms.TextBox volumenCubo;
        private System.Windows.Forms.TextBox ladoCubo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox areaCil;
        private System.Windows.Forms.TextBox volumenCil;
        private System.Windows.Forms.TextBox alturaCil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox radioCil;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox dMenor;
        private System.Windows.Forms.TextBox dMayor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox areaRombo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox volumenOct;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox areaOct;
        private System.Windows.Forms.TextBox ladoOct;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

