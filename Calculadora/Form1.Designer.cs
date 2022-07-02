namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numero_1 = new System.Windows.Forms.Button();
            this.numero_2 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.numero_3 = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.numero_4 = new System.Windows.Forms.Button();
            this.numero_5 = new System.Windows.Forms.Button();
            this.numero_6 = new System.Windows.Forms.Button();
            this.numero_7 = new System.Windows.Forms.Button();
            this.numero_8 = new System.Windows.Forms.Button();
            this.numero_9 = new System.Windows.Forms.Button();
            this.numero_0 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.itbis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero_1
            // 
            this.numero_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_1.Location = new System.Drawing.Point(127, 274);
            this.numero_1.Name = "numero_1";
            this.numero_1.Size = new System.Drawing.Size(135, 79);
            this.numero_1.TabIndex = 2;
            this.numero_1.Text = "1";
            this.numero_1.UseVisualStyleBackColor = true;
            this.numero_1.Click += new System.EventHandler(this.numero_1_Click);
            // 
            // numero_2
            // 
            this.numero_2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_2.Location = new System.Drawing.Point(286, 274);
            this.numero_2.Name = "numero_2";
            this.numero_2.Size = new System.Drawing.Size(137, 79);
            this.numero_2.TabIndex = 1;
            this.numero_2.Text = "2";
            this.numero_2.UseVisualStyleBackColor = true;
            this.numero_2.Click += new System.EventHandler(this.numero_2_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(127, 23);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(654, 158);
            this.resultado.TabIndex = 3;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // btn_resultado
            // 
            this.btn_resultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_resultado.Location = new System.Drawing.Point(127, 677);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(654, 85);
            this.btn_resultado.TabIndex = 4;
            this.btn_resultado.Text = "Resultado";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // numero_3
            // 
            this.numero_3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_3.Location = new System.Drawing.Point(443, 274);
            this.numero_3.Name = "numero_3";
            this.numero_3.Size = new System.Drawing.Size(137, 79);
            this.numero_3.TabIndex = 5;
            this.numero_3.Text = "3";
            this.numero_3.UseVisualStyleBackColor = true;
            this.numero_3.Click += new System.EventHandler(this.numero_3_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicar.Location = new System.Drawing.Point(127, 200);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(65, 53);
            this.multiplicar.TabIndex = 6;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.division.Location = new System.Drawing.Point(198, 200);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(64, 53);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumar.Location = new System.Drawing.Point(286, 200);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(63, 53);
            this.sumar.TabIndex = 8;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_limpiar.Location = new System.Drawing.Point(125, 778);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(656, 53);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // numero_4
            // 
            this.numero_4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_4.Location = new System.Drawing.Point(127, 374);
            this.numero_4.Name = "numero_4";
            this.numero_4.Size = new System.Drawing.Size(135, 79);
            this.numero_4.TabIndex = 10;
            this.numero_4.Text = "4";
            this.numero_4.UseVisualStyleBackColor = true;
            this.numero_4.Click += new System.EventHandler(this.numero_4_Click);
            // 
            // numero_5
            // 
            this.numero_5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_5.Location = new System.Drawing.Point(286, 374);
            this.numero_5.Name = "numero_5";
            this.numero_5.Size = new System.Drawing.Size(135, 79);
            this.numero_5.TabIndex = 11;
            this.numero_5.Text = "5";
            this.numero_5.UseVisualStyleBackColor = true;
            this.numero_5.Click += new System.EventHandler(this.numero_5_Click);
            // 
            // numero_6
            // 
            this.numero_6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_6.Location = new System.Drawing.Point(443, 374);
            this.numero_6.Name = "numero_6";
            this.numero_6.Size = new System.Drawing.Size(135, 79);
            this.numero_6.TabIndex = 12;
            this.numero_6.Text = "6";
            this.numero_6.UseVisualStyleBackColor = true;
            this.numero_6.Click += new System.EventHandler(this.numero_6_Click);
            // 
            // numero_7
            // 
            this.numero_7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_7.Location = new System.Drawing.Point(127, 474);
            this.numero_7.Name = "numero_7";
            this.numero_7.Size = new System.Drawing.Size(135, 79);
            this.numero_7.TabIndex = 13;
            this.numero_7.Text = "7";
            this.numero_7.UseVisualStyleBackColor = true;
            this.numero_7.Click += new System.EventHandler(this.numero_7_Click);
            // 
            // numero_8
            // 
            this.numero_8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_8.Location = new System.Drawing.Point(286, 474);
            this.numero_8.Name = "numero_8";
            this.numero_8.Size = new System.Drawing.Size(135, 79);
            this.numero_8.TabIndex = 14;
            this.numero_8.Text = "8";
            this.numero_8.UseVisualStyleBackColor = true;
            this.numero_8.Click += new System.EventHandler(this.numero_8_Click);
            // 
            // numero_9
            // 
            this.numero_9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_9.Location = new System.Drawing.Point(443, 474);
            this.numero_9.Name = "numero_9";
            this.numero_9.Size = new System.Drawing.Size(135, 79);
            this.numero_9.TabIndex = 15;
            this.numero_9.Text = "9";
            this.numero_9.UseVisualStyleBackColor = true;
            this.numero_9.Click += new System.EventHandler(this.numero_9_Click);
            // 
            // numero_0
            // 
            this.numero_0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero_0.Location = new System.Drawing.Point(286, 571);
            this.numero_0.Name = "numero_0";
            this.numero_0.Size = new System.Drawing.Size(135, 79);
            this.numero_0.TabIndex = 16;
            this.numero_0.Text = "0";
            this.numero_0.UseVisualStyleBackColor = true;
            this.numero_0.Click += new System.EventHandler(this.numero_0_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.punto.Location = new System.Drawing.Point(441, 571);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(135, 79);
            this.punto.TabIndex = 17;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrar.Location = new System.Drawing.Point(127, 571);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(135, 79);
            this.borrar.TabIndex = 18;
            this.borrar.Text = "c";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enter.Location = new System.Drawing.Point(596, 274);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(185, 376);
            this.enter.TabIndex = 19;
            this.enter.Text = "Entrada";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resta.Location = new System.Drawing.Point(355, 200);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(66, 53);
            this.resta.TabIndex = 20;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raiz.Location = new System.Drawing.Point(441, 200);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(66, 53);
            this.raiz.TabIndex = 21;
            this.raiz.Text = "X2";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // itbis
            // 
            this.itbis.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itbis.Location = new System.Drawing.Point(513, 200);
            this.itbis.Name = "itbis";
            this.itbis.Size = new System.Drawing.Size(267, 53);
            this.itbis.TabIndex = 22;
            this.itbis.Text = "Itbis";
            this.itbis.UseVisualStyleBackColor = true;
            this.itbis.Click += new System.EventHandler(this.itbis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(903, 871);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.numero_0);
            this.Controls.Add(this.numero_9);
            this.Controls.Add(this.numero_8);
            this.Controls.Add(this.numero_7);
            this.Controls.Add(this.numero_6);
            this.Controls.Add(this.numero_5);
            this.Controls.Add(this.numero_4);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.numero_3);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero_2);
            this.Controls.Add(this.numero_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button numero_1;
        private Button numero_2;
        private TextBox resultado;
        private Button btn_resultado;
        private Button numero_3;
        private Button multiplicar;
        private Button division;
        private Button sumar;
        private Button btn_limpiar;
        private Button numero_4;
        private Button numero_5;
        private Button numero_6;
        private Button numero_7;
        private Button numero_8;
        private Button numero_9;
        private Button numero_0;
        private Button punto;
        private Button borrar;
        private Button enter;
        private Button resta;
        private Button raiz;
        private Button itbis;
    }
}