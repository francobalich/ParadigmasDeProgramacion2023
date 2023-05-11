using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_cartas
{
    public class Card
    {
        private int numero;

        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int num = genRandom.Next(min, max + 1);
            return num;
        }

        public Card()
        {
            this.numero = generarNumeroRandom(1, 2);
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public override string ToString()
        {
            return $"Card: {this.numero}";
        }
    }
}
