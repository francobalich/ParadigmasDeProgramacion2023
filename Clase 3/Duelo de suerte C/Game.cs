using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duelo_de_suerte_C
{
    public class Game
    {
        private int numA = 0;
        private int numB = 0;

        public int NumA
        {
            get { return numA; }
        }

        public int NumB
        {
            get { return numB; }
        }

        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }
        
        public void determinarGanador()
        {
            if (numA > 0 && numB > 0)
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
            }
        }
        public void resetJugadores()
        {
            numA = 0;
            numB = 0;
        }
        public void cargarJugadorA(int min, int max)
        {
            this.numA = generarNumeroRandom(min, max);
        }

        public void cargarJugadorB(int min, int max)
        {
            this.numB = generarNumeroRandom(min, max);
        }
    }
}
