﻿using System;
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

        private int CalcularLado()
        {
            //Pitagoras hipotenusa al cuadrado es igual a catetos al cuadrado
             return (int) Math.Sqrt(Math.Pow(diagonal1/2, 2) + Math.Pow(diagonal2/2, 2));
        }

        public override float GetArea()
        {
            return (diagonal1 * diagonal2) / 2;
        }

        public override int GetPerimetro()
        {
            return CalcularLado() * 4;
        }

        public override string ToString()
        {
            return $"Rombo con diagonales {diagonal1} y {diagonal2}";
        }
    }
}
