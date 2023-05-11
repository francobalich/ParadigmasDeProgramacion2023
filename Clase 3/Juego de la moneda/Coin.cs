using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_moneda
{
    public class Coin
    {
        private PictureBox cara;
        private PictureBox cruz;

        public PictureBox Cara
        {
            get
            {
                return this.cara;
            }
            set
            {
                this.cara = value;
            }
        }
        public PictureBox Cruz
        {
            get
            {
                return this.cruz;
            }
            set
            {
                this.cruz = value;
            }
        }

        public void MostrarCara(int numRandom)
        {
            if (numRandom == 1)
            {
                this.cara.Show();
                this.cruz.Hide();
            }
            else
            {
                this.cara.Hide();
                this.cruz.Show();
            }
        }
    }
}
