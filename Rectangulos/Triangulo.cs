using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Rectangulos
{
    public class Triangulo : Figura
    {
        private const int Lado = 60;

        public Triangulo(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            Point[] puntos = new Point[3];
            puntos[0] = new Point(X, Y);
            puntos[1] = new Point(X - Lado / 2, Y + (int)(Math.Sqrt(3) * Lado / 2));
            puntos[2] = new Point(X + Lado / 2, Y + (int)(Math.Sqrt(3) * Lado / 2));
            using (Brush brush = new SolidBrush(ColorFigura))
            {
                g.FillPolygon(brush, puntos);
            }
        }
    }
}
