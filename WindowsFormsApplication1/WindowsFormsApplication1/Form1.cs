using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        circulo circ = new circulo();
        cuadrado cua = new cuadrado();
        rectangulo rec = new rectangulo();
        triangulo tri = new triangulo();
        List<figura> figs = new List<figura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dibujar_Click(object sender, EventArgs e)
        {
            circ.x = Convert.ToInt16(txt_x.Text);
            circ.y = Convert.ToInt16(txt_y.Text);
            circ.h = Convert.ToInt16(txt_h.Text);
            circ.b = Convert.ToInt16(txt_b.Text);
            figs.Add(circ);

            cua.x = Convert.ToInt16(txt_x.Text);
            cua.y = Convert.ToInt16(txt_y.Text);
            cua.h = Convert.ToInt16(txt_h.Text);
            cua.b = Convert.ToInt16(txt_b.Text);
            figs.Add(cua);


            //rec.x = Convert.ToInt16(txt_x.Text);
            //rec.y = Convert.ToInt16(txt_y.Text);
            //rec.h = Convert.ToInt16(txt_h.Text);
            //rec.b = Convert.ToInt16(txt_b.Text);
            //figs.Add(rec);

            tri.x = Convert.ToInt16(txt_x.Text);
            tri.y = Convert.ToInt16(txt_y.Text);
            tri.h = Convert.ToInt16(txt_h.Text);
            tri.b = Convert.ToInt16(txt_b.Text);
            figs.Add(tri);

            txt_circulo.Text = figs.ElementAt(0).pintar();
            txt_cuadrado.Text = figs.ElementAt(1).pintar();
           txt_triangulo.Text = figs.ElementAt(2).pintar();

        }
    }
}
