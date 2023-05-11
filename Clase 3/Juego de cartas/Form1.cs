using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_cartas
{
    public partial class Form1 : Form
    {
        private Game juego = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            try
            {
                pbxCartaA.Show();
                pbxCartaB.Show();
                pbxCartaC.Show();
                pbxCartaD.Show();

                juego.cargarCartas();

                if (juego.CartaBuscada.Numero == 1)
                {
                    lblCartaABuscar.Text = "Con un circulo";
                }
                else
                {
                    lblCartaABuscar.Text = "Con un triangulo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //pbxTriangulo.Hide();
            //pbxCirculo.Hide();
        }
        private void mostrarResultado(int valor)
        {
            if(valor!= 0)
            {
                if (valor == juego.CartaBuscada.Numero)
                {
                    MessageBox.Show("Adivinaste");
                }
                else
                {
                    MessageBox.Show("Màs suerte la proxima.");
                }
                reset();
            }
        }
        
        private void mostrarCarta(int valor, Point posicion) {
            if (valor == 1)
            {
                pbxCirculo.Location = posicion;
            }
            else
            {
                pbxTriangulo.Location = posicion;
            }
        }
        
        private void pbxCartaA_Click(object sender, EventArgs e)
        {
            int valor = juego.obtenerCarta(0).Numero;

            Point posicion = new Point(pbxCartaA.Location.X, pbxCartaA.Location.Y);
            pbxCartaA.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);

        }
        private void pbxCartaB_Click(object sender, EventArgs e)
        {
            int valor = juego.obtenerCarta(1).Numero;

            Point posicion = new Point(pbxCartaB.Location.X, pbxCartaB.Location.Y);
            pbxCartaB.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }

        private void pbxCartaC_Click(object sender, EventArgs e)
        {
            int valor = juego.obtenerCarta(2).Numero;
            Point posicion = new Point(pbxCartaC.Location.X, pbxCartaC.Location.Y);
            pbxCartaC.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }

        private void pbxCartaD_Click(object sender, EventArgs e)
        {
            int valor = juego.obtenerCarta(3).Numero;
            Point posicion = new Point(pbxCartaD.Location.X, pbxCartaD.Location.Y);
            pbxCartaD.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }
    }
}
