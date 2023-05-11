using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Juego_de_cartas
{
    public class Game
    {
        private List<Card> cards = new List<Card>();
        private Card cartaBuscada = new Card();

        public Game() 
        {
            cargarCartas();
        }

        public Card CartaBuscada
        {
            get { return this.cartaBuscada; }
            set { this.cartaBuscada = value; }
        }

        public void cargarCartas()
        {
            // 1 = circulo
            // 2 = triangulo

            this.cards.Clear();
            this.cartaBuscada = new Card();

            for (int i = 0; i < 4; i++)
            {
                Card carta = new Card();
                this.cards.Add(carta);
                Thread.Sleep(100);
            }
        }
        public Card obtenerCarta(int index)
        {
            return this.cards[index];
        }
    }
}
