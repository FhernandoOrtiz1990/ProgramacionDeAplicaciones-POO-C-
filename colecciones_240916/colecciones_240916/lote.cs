using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones_240916
{
    public class lote
    {
        private List<auto> milote = new List<auto>();
        

        public int CountA1
        {
            get
            {
                return milote.Count;
            }}

        public void addAuto( auto nuevo)
        {
            this.milote.Add(nuevo);
        }
        public auto getautoby( int i)
        {
            auto auxA = new auto();
            if ((i>=0)&&(i<this.milote.Count))
            auxA = this.milote.ElementAt(i);
            return auxA;
        }     
    }
}
