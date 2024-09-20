using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Triangulo : Poligono
    {
        int baseTriangulo;
        int altura;
        double angulo;

        public Triangulo() { }

        public Triangulo(int baseTriangulo, int altura, int angulo) : base(3)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            //Lo pasamos de grados a radianes
            this.angulo = angulo * (Math.PI / 180);
        }

        public override float GetArea() 
        {
            return (baseTriangulo * altura) / 2;
        }

        public override int GetPerimetro()
        {
            // Calcular el lado adyacente al ángulo (hipotenusa en un triángulo rectángulo que formaría la altura)
            int ladoAdyacente = (int) (altura / Math.Sin(angulo));

            // Calcular el lado opuesto (largo del otro lado)
            int ladoOpuesto = (int) (baseTriangulo / Math.Cos(angulo));

            // Calcular el perímetro sumando los lados
            return  baseTriangulo + ladoAdyacente + ladoOpuesto;
        }

        public override string ToString()
        {
            return $"Triangulo con base {baseTriangulo}, altura {altura} y angulo {angulo}.";
        }
    }
}
