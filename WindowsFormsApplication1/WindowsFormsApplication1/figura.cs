using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class figura:IPosicion,IOpers
    {
        public int x { get; set;}
        public int y { get; set; }
        public double h { get; set; }
        public double b { get; set; }

        public int x1 { get; set; }
        public int y1 { get; set; }
        public virtual String pintar()
        {
            String res = "";
            res = "figura de" + this.x.ToString();
            res = res + "a" + this.y.ToString();
            return res;
        }
        public double area()
        {
            double a = this.h * this.b;
            return a;

        }
        public double perimetro()
        {
            return 0.0;
        }
    }
}
