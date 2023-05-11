using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_moneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Moneda moneda;
        private void Form1_Load(object sender, EventArgs e)
        {
            moneda = new Moneda();
            moneda.Cruz = pbxCruz;
            moneda.Cara = pbxCara;
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            GeneradorRandom genRandom = new GeneradorRandom();
            int a = genRandom.generarNumero(0,1);

            moneda.MostrarCara(genRandom.NumeroRandom);
        }
        public class GeneradorRandom
        {
            private int minimo;
            private int maximo;
            private int numeroRandom;

            public int Minimo {
                get
                {
                    return this.minimo;
                }
                set {
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
        public class Moneda
        {
            private PictureBox cara;
            private PictureBox cruz;

            public PictureBox Cara { 
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
}
