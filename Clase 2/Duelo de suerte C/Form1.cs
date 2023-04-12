using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duelo_de_suerte_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numA = 0;
        int numB = 0;
        private int generarNumeroRandom(int min,int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }
        private void mostrarGanador()
        {
            if (numA>0 && numB>0)
            {
                if (numA > numB)
                {
                    MessageBox.Show("Gano el Jugador A", "Resultado del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numA == numB)
                {
                    MessageBox.Show("Fue un empate", "Resultado del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gano el Jugador B", "Resultado del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                numA = 0;
                numB = 0;
                lblNumA.Text = numA.ToString();
                lblNumB.Text = numB.ToString();
            }
        }
        private void btnJugadorA_Click(object sender, EventArgs e)
        {
            numA = generarNumeroRandom(0, 10);
            lblNumA.Text = numA.ToString();
            mostrarGanador();
        }

        private void btnJugadorB_Click(object sender, EventArgs e)
        {
            numB = generarNumeroRandom(1, 10);
            lblNumB.Text = numB.ToString();
            mostrarGanador();
        }
    }
}
