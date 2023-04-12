using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_cartas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // int[] cartas = new int[4];
        int[] cartas = { 2, 1, 2, 1 };
        int carta = 0;
        // int[] cartas = new int[4] { 0, 1, 2, 3 };
        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region comment
                //lblCartaABuscar.Text = cartas[4].ToString();
                // 1 = circulo
                // 2 = triangulo
                /*
                for(int i =0; i < cartas.Length; i++)
                {
                    int num = generarNumeroRandom(1, 2);
                    cartas[i] = num;
                }*/

                //string msg = "";
                /*
                for (int i = 0; i < cartas.Length; i++)
                {
                    msg = msg + cartas[i].ToString() + ", ";
                    
                }*/
                //MessageBox.Show(msg);
                #endregion comment

                carta = generarNumeroRandom(1, 2);
                if (carta == 1)
                {
                    lblCartaABuscar.Text = "Con un circulo";
                }
                else
                {
                    lblCartaABuscar.Text = "Con un triangulo";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrarResultado(int valor)
        {
            if(valor!= 0)
            {
                if (valor == carta)
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
        private void reset()
        {
            pbxCartaA.Show();
            pbxCartaB.Show();
            pbxCartaC.Show();
            pbxCartaD.Show();

            //pbxTriangulo.Hide();
            //pbxCirculo.Hide();
        }
        private void pbxCartaA_Click(object sender, EventArgs e)
        {
            int valor = cartas[0];

            Point posicion = new Point(pbxCartaA.Location.X, pbxCartaA.Location.Y);
            pbxCartaA.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);

        }
        private void pbxCartaB_Click(object sender, EventArgs e)
        {
            int valor = cartas[1];
            
            Point posicion = new Point(pbxCartaB.Location.X, pbxCartaB.Location.Y);
            pbxCartaB.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }

        private void pbxCartaC_Click(object sender, EventArgs e)
        {
            int valor = cartas[2];
            Point posicion = new Point(pbxCartaC.Location.X, pbxCartaC.Location.Y);
            pbxCartaC.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }

        private void pbxCartaD_Click(object sender, EventArgs e)
        {
            int valor = cartas[3];
            Point posicion = new Point(pbxCartaD.Location.X, pbxCartaD.Location.Y);
            pbxCartaD.Hide();
            mostrarCarta(valor, posicion);
            mostrarResultado(valor);
        }
    }
}
