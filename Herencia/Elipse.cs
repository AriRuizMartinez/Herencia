using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Elipse : Forma2D
    {
        protected int radio1;
        protected int radio2;

        public Elipse() { }

        public Elipse(int radio1, int radio2)
        {
            this.radio1 = radio1;
            this.radio2 = radio2;
        }
    }
}
