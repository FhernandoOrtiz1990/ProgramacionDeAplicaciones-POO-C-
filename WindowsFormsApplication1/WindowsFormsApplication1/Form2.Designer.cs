namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_mover = new System.Windows.Forms.Button();
            this.pnl_imagen = new System.Windows.Forms.Panel();
            this.ptb_imagen = new System.Windows.Forms.PictureBox();
            this.pnl_imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            // 
            // txt_y1
            // 
            this.txt_y1.Location = new System.Drawing.Point(312, 81);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.Size = new System.Drawing.Size(100, 20);
            this.txt_y1.TabIndex = 11;
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(130, 81);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(100, 20);
            this.txt_x1.TabIndex = 10;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(312, 29);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 9;
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(130, 29);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "B";
            // 
            // btn_mover
            // 
            this.btn_mover.Location = new System.Drawing.Point(488, 139);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(75, 23);
            this.btn_mover.TabIndex = 16;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = true;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // pnl_imagen
            // 
            this.pnl_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_imagen.Controls.Add(this.ptb_imagen);
            this.pnl_imagen.Location = new System.Drawing.Point(62, 194);
            this.pnl_imagen.Name = "pnl_imagen";
            this.pnl_imagen.Size = new System.Drawing.Size(738, 337);
            this.pnl_imagen.TabIndex = 17;
            // 
            // ptb_imagen
            // 
            this.ptb_imagen.Image = ((System.Drawing.Image)(resources.GetObject("ptb_imagen.Image")));
            this.ptb_imagen.Location = new System.Drawing.Point(68, 36);
            this.ptb_imagen.Name = "ptb_imagen";
            this.ptb_imagen.Size = new System.Drawing.Size(144, 97);
            this.ptb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_imagen.TabIndex = 0;
            this.ptb_imagen.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 562);
            this.Controls.Add(this.pnl_imagen);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_y1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_x1);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_y1;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.Panel pnl_imagen;
        private System.Windows.Forms.PictureBox ptb_imagen;
    }
}