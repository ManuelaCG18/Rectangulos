using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rectangulos
{
    public class FiguraFactory
    {
        public static Figura CrearRectangulo(int x, int y, Color color)
        {
            return new Rectangulo(x, y, color);
        }

        public static Figura CrearCirculo(int x, int y, Color color)
        {
            return new Circulo(x, y, color);
        }

        public static Figura CrearLinea(int x, int y, Color color)
        {
            return new Linea(x, y, color);
        }

        public static Figura CrearTriangulo(int x, int y, Color color)
        {
            return new Triangulo(x, y, color);
        }
    }
}
