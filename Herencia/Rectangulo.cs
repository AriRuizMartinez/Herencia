using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Rectangulo : Poligono
    {
        protected int baseRectangulo;
        protected int altura;

        public Rectangulo() { }

        public Rectangulo(int baseRectangulo, int altura) : base(4)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
    }
}
