using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nuevo
{
    public partial class Form1 : Form
    {
        String sex="";
        String H = "H";
        String lnac = "";
        String Pue = "PL";
        private persona per = new persona();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.per.setnombre(txt_nombre.Text);
            this.per.setcurp(txt_curp.Text);
            txt_fecha_nacimiento.Text = this.per.getcurp().Substring(4, 6);
            lnac = this.per.getcurp().Substring(11, 2);
            sex = this.per.getcurp().Substring(10, 1);
            if (sex == H)
            {
                txt_sexo.Text = "Hombre";
            }
            else
            {
                txt_sexo.Text = "Mujer";
            }

            if (lnac == Pue)
            {
                txt_lugar_nacimiento.Text = "Puebla";


        }
            else { txt_lugar_nacimiento.Text = "otro lado"; }

        

        
    }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    this.close();
            //}
        }
    }
}