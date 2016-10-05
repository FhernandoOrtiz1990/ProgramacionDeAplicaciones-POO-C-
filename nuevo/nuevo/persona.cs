using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class persona
    {
        private String nombre; // atributos  de la clase
        private String curp;

        public String getcurp()  // metodos de la clase, acciones que puedes hacer con esta clase
        {
            return this.curp;
        }
        public void setcurp(String c)
        {
            this.curp = c;
        }
        public String getnombre()
        {
            return this.nombre;
        }

        public void setnombre(String n)
        {
            this.nombre = n;
        }
    }
}

