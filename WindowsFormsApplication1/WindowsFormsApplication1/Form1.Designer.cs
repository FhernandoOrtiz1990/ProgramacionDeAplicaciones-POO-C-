namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_circulo = new System.Windows.Forms.TextBox();
            this.txt_cuadrado = new System.Windows.Forms.TextBox();
            this.txt_triangulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_dibujar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(145, 64);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 0;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(327, 64);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 1;
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(145, 171);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 20);
            this.txt_h.TabIndex = 2;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(327, 171);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 3;
            // 
            // txt_circulo
            // 
            this.txt_circulo.Location = new System.Drawing.Point(273, 338);
            this.txt_circulo.Name = "txt_circulo";
            this.txt_circulo.Size = new System.Drawing.Size(100, 20);
            this.txt_circulo.TabIndex = 4;
            // 
            // txt_cuadrado
            // 
            this.txt_cuadrado.Location = new System.Drawing.Point(273, 386);
            this.txt_cuadrado.Name = "txt_cuadrado";
            this.txt_cuadrado.Size = new System.Drawing.Size(100, 20);
            this.txt_cuadrado.TabIndex = 5;
            // 
            // txt_triangulo
            // 
            this.txt_triangulo.Location = new System.Drawing.Point(273, 423);
            this.txt_triangulo.Name = "txt_triangulo";
            this.txt_triangulo.Size = new System.Drawing.Size(100, 20);
            this.txt_triangulo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Circulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cuadrado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Triangulo";
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(345, 226);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(75, 23);
            this.btn_area.TabIndex = 8;
            this.btn_area.Text = "Área";
            this.btn_area.UseVisualStyleBackColor = true;
            // 
            // btn_dibujar
            // 
            this.btn_dibujar.Location = new System.Drawing.Point(145, 226);
            this.btn_dibujar.Name = "btn_dibujar";
            this.btn_dibujar.Size = new System.Drawing.Size(75, 23);
            this.btn_dibujar.TabIndex = 9;
            this.btn_dibujar.Text = "Dibujar";
            this.btn_dibujar.UseVisualStyleBackColor = true;
            this.btn_dibujar.Click += new System.EventHandler(this.btn_dibujar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 530);
            this.Controls.Add(this.btn_dibujar);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_triangulo);
            this.Controls.Add(this.txt_cuadrado);
            this.Controls.Add(this.txt_circulo);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_circulo;
        private System.Windows.Forms.TextBox txt_cuadrado;
        private System.Windows.Forms.TextBox txt_triangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_dibujar;
    }
}

