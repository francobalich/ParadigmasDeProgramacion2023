using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuentra_al_impostor
{
    public partial class Form1 : Form
    {
        private Juego juego = new Juego();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego.CargarJugadores();
            juego.ImpostorGanador += impostorGanador;
            juego.InocenteGanador += inocentesGanador;
        }
        private void impostorGanador(object sender, EventArgs e)
        {
            MessageBox.Show("El importor gano");
            this.Close();
        }
        private void inocentesGanador(object sender, EventArgs e)
        {
            MessageBox.Show("¡Los inocentes ganaron!");
            this.Close();
        }
        private void btnJugador1_Click(object sender, EventArgs e)
        {
            try
            {
                string msg=juego.ComprobarGanador(1);
                MessageBox.Show(msg);
                btnJugador1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJugador2_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = juego.ComprobarGanador(2);
                MessageBox.Show(msg);
                btnJugador2.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJugador3_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = juego.ComprobarGanador(3);
                MessageBox.Show(msg);
                btnJugador3.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJugador4_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = juego.ComprobarGanador(4);
                MessageBox.Show(msg);
                btnJugador4.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
