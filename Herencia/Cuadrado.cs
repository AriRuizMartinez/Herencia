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

        public Cuadrado(int baseR, int altura, int lado) : base(baseR, altura, lado, lado) { }
    }
}
