using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_la_moneda
{
    public class GeneradorRandom
    {
        private int minimo;
        private int maximo;
        private int numeroRandom;

        public int Minimo
        {
            get
            {
                return this.minimo;
            }
            set
            {
                this.minimo = value;
            }
        }
        public int Maximo
        {
            get
            {
                return this.maximo;
            }
            set
            {
                this.maximo = value;
            }
        }
        public int NumeroRandom
        {
            get
            {
                return this.numeroRandom;
            }
        }
        public int generarNumero()
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            this.numeroRandom = genRandom.Next(this.minimo, this.Maximo + 1);

            return this.numeroRandom;
        }
        public int generarNumero(int pMinimo, int pMaximo)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            this.numeroRandom = genRandom.Next(pMinimo, pMaximo + 1);

            return this.numeroRandom;
        }
    }
}
