using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Poligono : Forma2D
    {
        protected int numeroDeLados;

        public Poligono() { }

        public Poligono(int lados) 
        {
            numeroDeLados = lados;
        }

    }
}
