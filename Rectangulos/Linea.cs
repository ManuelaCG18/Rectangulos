using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulos
{
    public class Linea : Figura
    {
        private const int Longitud = 60;

        public Linea(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(ColorFigura, 3))
            {
                g.DrawLine(pen, X, Y, X + Longitud, Y);
            }
        }
    }
}
