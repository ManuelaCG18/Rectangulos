using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rectangulos
{
    public class Rectangulo : Figura
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }


        public Rectangulo(int x, int y, Color color, int ancho = 100, int alto = 50)
        {
            X = x;
            Y = y;
            Color = color;
            Ancho = ancho;
            Alto = alto;
        }

        public override void Dibujar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, Ancho, Alto);
            }
        }
    }
}
