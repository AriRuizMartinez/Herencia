using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Elipse : IForma2D
    {
        protected int radio1;
        protected int radio2;

        public Elipse() { }

        public Elipse(int radio1, int radio2)
        {
            this.radio1 = radio1;
            this.radio2 = radio2;
        }

        public float GetArea()
        {
            return (float) (radio1 * radio2 * Math.PI);
        }

        public int GetPerimetro()
        {
            // Fórmula de Ramanujan
            double pi = Math.PI; 
            double term1 = 3 * (radio1 + radio2); 
            double term2 = Math.Sqrt((3 * radio1 + radio2) * (radio1 + 3 * radio2)); 
            return (int) (pi * (term1 - term2)); 
        }

        public override string ToString()
        {
            return $"Elipse de radios {radio1} y {radio2}";
        }
    }
}
