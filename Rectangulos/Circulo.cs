using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulos
{
    public class Circulo : Figura
    {
        private int radio { get; set; }

        public Circulo(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(ColorFigura))
            {
                g.FillEllipse(brush, X - radio, Y - radio, 2 * radio, 2 * radio);
            }
        }
    }
}
