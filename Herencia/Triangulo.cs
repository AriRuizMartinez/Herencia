using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Triangulo : Poligono
    {
        int lado1;
        int lado2;
        int lado3;

        int baseTriangulo;
        int altura;
        int angulo;

        public Triangulo() { }

        public Triangulo(int lado1, int lado2, int lado3, int baseTriangulo, int altura, int angulo) : base(3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.angulo = angulo;
        }
    }
}
