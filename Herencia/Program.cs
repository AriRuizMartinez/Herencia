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

            Console.WriteLine(elipse.ToString());
            Console.WriteLine("Area: " + elipse.GetArea());
            Console.WriteLine("Perimetro: " + elipse.GetPerimetro());
            Console.WriteLine(circulo.ToString());
            Console.WriteLine("Area: " + circulo.GetArea());
            Console.WriteLine("Perimetro: " + circulo.GetPerimetro());
            Console.WriteLine(triangulo.ToString());
            Console.WriteLine("Area: " + triangulo.GetArea());
            Console.WriteLine("Perimetro: " + triangulo.GetPerimetro());
            Console.WriteLine(rombo.ToString());
            Console.WriteLine("Area: " + rombo.GetArea());
            Console.WriteLine("Perimetro: " + rombo.GetPerimetro());
            Console.WriteLine(cuadrado.ToString());
            Console.WriteLine("Area: " + cuadrado.GetArea());
            Console.WriteLine("Perimetro: " + cuadrado.GetPerimetro());
            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine("Area: " + rectangulo.GetArea());
            Console.WriteLine("Perimetro: " + rectangulo.GetPerimetro());
        }
    }
}
