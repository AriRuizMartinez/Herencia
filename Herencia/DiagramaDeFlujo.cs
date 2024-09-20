using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class DiagramaDeFlujo
    {
        List<IForma2D> FlujoList;

        public DiagramaDeFlujo()
        {
            FlujoList = new List<IForma2D>();

            Random r = new Random();

            int cantidad = r.Next(2, 1000);

            Array formas = Enum.GetValues(typeof(eForma2D));

            for (int i = 0; i < cantidad; i++)
            {
                switch(formas.GetValue(r.Next(0, formas.Length))) 
                {
                    case eForma2D.Rectangulo:
                        FlujoList.Add(new Rectangulo(r.Next(1, 100), r.Next(1, 100)));
                        break;
                    case eForma2D.Circulo:
                        FlujoList.Add(new Circulo(r.Next(1, 100)));
                        break;
                    case eForma2D.Cuadrado:
                        FlujoList.Add(new Cuadrado(r.Next(1, 100)));
                        break;
                    case eForma2D.Triangulo:
                        FlujoList.Add(new Triangulo(r.Next(1, 100), r.Next(1, 100), r.Next(1, 178)));
                        break;
                    case eForma2D.Elipse:
                        FlujoList.Add(new Elipse(r.Next(1, 100), r.Next(1, 100)));
                        break;
                    case eForma2D.Rombo:
                        FlujoList.Add(new Rombo(r.Next(1, 100), r.Next(1, 100)));
                        break;
                }
            };
        }

        public float GetArea()
        {
            float total = 0;
            foreach (IForma2D forma in FlujoList)
                total += forma.GetArea();
            return total;
        }
        public int GetPerimetro()
        {
            int total = 0;
            foreach (IForma2D forma in FlujoList)
                total += forma.GetPerimetro();
            return total;
        }

        public override string ToString()
        {
            string frase = $"Diagrama con {FlujoList.Count} formas. \n";

            foreach(IForma2D forma in FlujoList)
                frase += forma.ToString() + "\n";
            return frase;
        }
    }

}
