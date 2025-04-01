using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangulos
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>(); // lista de figuras dibujadas
        private int contadorRectangulos = 0;
        private Color colorSeleccionado = Color.Pink;
        public Form1()
        {
            InitializeComponent();
            // falta
        }


        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(g);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtCoordenadaX.Text);
                int y = int.Parse(txtCoordenadaY.Text);

                Figura rectangulo = FiguraFactory.CrearRectangulo(x, y, colorSeleccionado);
                figuras.Add(rectangulo);
                contadorRectangulos++;

                lblContador.Text = "Rectangulos creados: " + contadorRectangulos;
                panelDibujo.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos para las coordenadas X y Y ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    picColor.BackColor = colorSeleccionado; // muestra el color seleccionado
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            contadorRectangulos = 0;
            lblContador.Text = "Rectangulos creados: 0 ";
            panelDibujo.Invalidate();
        }
    }
}
