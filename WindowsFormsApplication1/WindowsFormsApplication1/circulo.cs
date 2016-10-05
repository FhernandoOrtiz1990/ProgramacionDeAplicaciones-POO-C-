using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public   class circulo:figura
    {
        public override string pintar()
        {
            String res = "pintar circulo" + this.x.ToString();
            res = res + "a" + this.y.ToString();
            return res;
        }
    }
}
