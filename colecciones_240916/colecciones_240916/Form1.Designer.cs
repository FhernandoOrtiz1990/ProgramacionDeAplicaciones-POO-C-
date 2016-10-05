namespace colecciones_240916
{
    partial class frm_colecciones
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
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Molelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_indice = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nAutos = new System.Windows.Forms.Label();
            this.lbl_nameAuto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(116, 115);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 20);
            this.txt_color.TabIndex = 0;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(116, 66);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(141, 172);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Molelo
            // 
            this.Molelo.AutoSize = true;
            this.Molelo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Molelo.Location = new System.Drawing.Point(31, 66);
            this.Molelo.Name = "Molelo";
            this.Molelo.Size = new System.Drawing.Size(38, 13);
            this.Molelo.TabIndex = 3;
            this.Molelo.Text = "Molelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // txt_indice
            // 
            this.txt_indice.Location = new System.Drawing.Point(116, 213);
            this.txt_indice.Name = "txt_indice";
            this.txt_indice.Size = new System.Drawing.Size(100, 20);
            this.txt_indice.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(141, 253);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indice";
            // 
            // lbl_nAutos
            // 
            this.lbl_nAutos.AutoSize = true;
            this.lbl_nAutos.Location = new System.Drawing.Point(138, 22);
            this.lbl_nAutos.Name = "lbl_nAutos";
            this.lbl_nAutos.Size = new System.Drawing.Size(92, 13);
            this.lbl_nAutos.TabIndex = 6;
            this.lbl_nAutos.Text = "Número de Autos:";
            // 
            // lbl_nameAuto
            // 
            this.lbl_nameAuto.Location = new System.Drawing.Point(34, 314);
            this.lbl_nameAuto.Name = "lbl_nameAuto";
            this.lbl_nameAuto.Size = new System.Drawing.Size(182, 20);
            this.lbl_nameAuto.TabIndex = 7;
            // 
            // frm_colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 382);
            this.Controls.Add(this.lbl_nameAuto);
            this.Controls.Add(this.lbl_nAutos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_indice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Molelo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_color);
            this.Name = "frm_colecciones";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.frm_colecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label Molelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_indice;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nAutos;
        private System.Windows.Forms.TextBox lbl_nameAuto;
    }
}

