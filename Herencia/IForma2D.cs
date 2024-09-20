using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public interface IForma2D
    {

        float GetArea();
        int GetPerimetro();
    }



    public enum eForma2D
    {
        Elipse,
        Circulo,
        Poligono,
        Triangulo,
        Cuadrado,
        Rectangulo,
        Rombo
    }
}
