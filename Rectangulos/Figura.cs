using System;
using System.Collections.Generic;
using System.Drawing; // este es necesario para usar Color y Graphics
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulos
{
    public abstract class Figura
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color ColorFigura { get; set; }

        public Figura(int x, int y, Color color)
        {
            X = x;
            Y = y;
            ColorFigura = color;
        }
        public abstract void Dibujar(Graphics g);
    }
}
