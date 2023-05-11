using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_personaje
{
    public partial class Form1 : Form
    {
        private Personaje robot = new Personaje("Roby");

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            robot.atacar();
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {
            robot.defender();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            robot.dormir();
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            robot.tomarItem("escudo");
        }

        private void btnSoltar_Click(object sender, EventArgs e)
        {
            robot.soltarItem("tornillo");
        }
    }
}
