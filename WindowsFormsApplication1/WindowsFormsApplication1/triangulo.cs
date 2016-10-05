using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class triangulo:figura
    {
        public override string pintar()
        {
            String res = "pintar triangulo" + this.x.ToString();
            res = res + "a" + this.y.ToString();
            return res;
        }
    }
}
