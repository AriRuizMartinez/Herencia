using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elipse elipse = new Elipse(1, 2);
            Circulo circulo = new Circulo(5);
            Triangulo triangulo = new Triangulo(5, 4, 3, 4, 3, 90);
            Rombo rombo = new Rombo(10, 5);
            Cuadrado cuadrado = new Cuadrado(5);
            Rectangulo rectangulo = new Rectangulo(3, 5);
        }
    }
}
