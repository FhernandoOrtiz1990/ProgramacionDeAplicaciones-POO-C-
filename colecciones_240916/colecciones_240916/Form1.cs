using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colecciones_240916
{
   
    public partial class frm_colecciones : Form
    {
        private lote misAutos = new lote();
        public frm_colecciones()
        {
            InitializeComponent();
        }

        private void frm_colecciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            auto newAut = new auto();
            newAut.Modelo = txt_modelo.Text;
            newAut.Color = txt_color.Text;
            this.misAutos.addAuto(newAut);
            lbl_nAutos.Text = this.misAutos.CountA1.ToString() + "Autos";
            txt_modelo.Text = " ";
            txt_color.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            auto a;

            int i = Convert.ToInt16(txt_indice.Text);
            a = this.misAutos.getautoby(i - 1);
            lbl_nameAuto.Text=a.Modelo + " " + a.Color;
            
        }
    }
}
