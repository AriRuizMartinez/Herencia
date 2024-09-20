using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Circulo : Elipse
    {
        public Circulo() { }

        public Circulo(int radio) : base(radio, radio) { }
    }
}
