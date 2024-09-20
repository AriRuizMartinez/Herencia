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

        public new int GetPerimetro()
        {
            return (int)(Math.PI * 2 * radio1);
        }

        public override string ToString()
        {
            return "Circulo de radio " + radio1;
        }
    }
}
