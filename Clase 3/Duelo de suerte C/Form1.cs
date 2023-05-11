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
        private Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrarGanador()
        {
            game.determinarGanador();
            if (game.NumA > 0 && game.NumB > 0)
            {
                lblNumA.Text = game.NumA.ToString();
                lblNumB.Text = game.NumB.ToString();
                game.resetJugadores();  
            }
            else
            {
                lblNumA.Text = game.NumA.ToString();
                lblNumB.Text = game.NumB.ToString();
            }
        }
        private void btnJugadorA_Click(object sender, EventArgs e)
        {
            game.cargarJugadorA(0, 10);
            lblNumA.Text = game.NumA.ToString();
            mostrarGanador();
        }

        private void btnJugadorB_Click(object sender, EventArgs e)
        {
            game.cargarJugadorB(0, 10);
            lblNumB.Text = game.NumB.ToString();
            mostrarGanador();
        }
    }
}
