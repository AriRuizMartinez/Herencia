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
        }

        public int GetArea()
        {
            return baseRectangulo * altura;
        }

        public int GetPerimetro()
        {
            return baseRectangulo * 2 + altura * 2;
        }

        public override string ToString()
        {
            return $"Rectangulo de base {baseRectangulo} y altura {altura}";
        }
    }
}
