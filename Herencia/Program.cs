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
            DiagramaDeFlujo diagrama = new DiagramaDeFlujo();

            Console.WriteLine(diagrama.ToString());
            Console.WriteLine("Area total: " + diagrama.GetArea());
            Console.WriteLine("Perimetro total: " + diagrama.GetPerimetro());
        }
    }
}
