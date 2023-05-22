using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Adivina_el_numero
{
    public partial class Form1 : Form
    {
        private Juego juego;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Juego();
            juego.Ganador += msgGanador;
        }
        private void msgGanador(object sender, EventArgs e)
        {
            MessageBox.Show("GANASTE");
        }
        private void btnRegistrarJugadores_Click(object sender, EventArgs e)
        {
            try
            {
                string primerNombre = Interaction.InputBox("Ingrese el nombre del primer jugador:");
                string segundoNombre = Interaction.InputBox("Ingrese el nombre del segundo jugador:");

                juego.CargarJugadores(primerNombre, segundoNombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!juego.HayJugadores())
                {
                    MessageBox.Show("Aun no cargo el nombre de los jugadores");
                }
                else
                {
                    string numeroText = Interaction.InputBox($"{juego.PrimerJugador.ToString()}, ingrese el numero a adivinar.");
                    int numero = 0;
                    bool success = int.TryParse(numeroText, out numero);

                    if (!success)
                    {
                        MessageBox.Show($"{juego.PrimerJugador.ToString()}, el numero a adivinar no puede ser un texto.");
                    }
                    juego.Numero = numero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (juego.HayJugadores() && txtNumero.Text == "")
                {
                    lblMensaje.Text = $"{juego.SegundoJugador.ToString()}, ingrese un numero";
                }
                else if(!juego.HayJugadores())
                {
                    MessageBox.Show("El jugador 1 aun no ingreso un numero");
                }
                else 
                {
                    string numeroText = txtNumero.Text;
                    int numero = 0;
                    bool success = int.TryParse(numeroText, out numero);

                    if (!success)
                    {
                        MessageBox.Show($"{juego.SegundoJugador.ToString()}, el numero no puede ser un texto.");
                    }
                    lblMensaje.Text = juego.DeterminarGanador(numero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
