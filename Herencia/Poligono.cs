using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Poligono : IForma2D
    {
        protected int numeroDeLados;

        public Poligono() { }

        public Poligono(int lados) 
        {
            numeroDeLados = lados;
        }

        public abstract float GetArea();

        public abstract int GetPerimetro();
    }
}
