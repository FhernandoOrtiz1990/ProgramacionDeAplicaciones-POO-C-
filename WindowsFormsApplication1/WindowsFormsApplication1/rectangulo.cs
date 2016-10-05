using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class rectangulo:figura
    {
       public double B {
            get {

                return this.x1 - this.x; }
                
        }
        public double H  { get { return this.y1 - this.y; }
         
            }
        }
    }

