using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado() { }

        public Cuadrado(int altura) : base(altura, altura) { }

        public override string ToString()
        {
            return "Cuadrado de lado " + altura;
        }
    }
}
