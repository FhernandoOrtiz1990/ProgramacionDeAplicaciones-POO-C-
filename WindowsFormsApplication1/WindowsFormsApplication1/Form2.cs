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
    public partial class Form2 : Form
    {

        rectangulo marco = new rectangulo();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            marco.x = Convert.ToInt16(txt_x.Text);
            marco.y = Convert.ToInt16(txt_y.Text);
            marco.x1 = Convert.ToInt16(txt_x1.Text);
            marco.y1 = Convert.ToInt16(txt_y1.Text);
            ptb_imagen.Top = marco.y;
            ptb_imagen.Left = marco.x;
            ptb_imagen.Width = (int)marco.B;
            ptb_imagen.Height = (int)marco.H;

        }
    }
}
