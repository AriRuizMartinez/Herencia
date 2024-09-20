using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Rombo : Poligono
    {
        int diagonal1;
        int diagonal2;

        public Rombo() { }
        public Rombo(int diagonal1, int diagonal2) : base(4) 
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }
    }
}
