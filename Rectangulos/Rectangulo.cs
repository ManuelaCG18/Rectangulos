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
        private int Ancho = 100;
        private int Alto = 50;


        public Rectangulo(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(ColorFigura))
            {
                g.FillRectangle(brush, X, Y, Ancho, Alto);
            }
        }
    }
}
