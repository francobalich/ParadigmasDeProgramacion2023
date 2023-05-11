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
        public Form1()
        {
            InitializeComponent();
        }
        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }
        private void atacar()
        {
            int daño= generarNumeroRandom(100, 1000);
            MessageBox.Show("El personaje ataco con " + daño.ToString() +" de daño." , "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void defender()
        {
            int resultado = generarNumeroRandom(0, 1);
            if (resultado == 1){
                MessageBox.Show("El personaje se defendio correctamente", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("El personaje no se pudo defender.", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void dormir()
        {
            MessageBox.Show("El personaje dormio", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void soltarItem()
        {
            MessageBox.Show("El personaje solto un item", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tomarItem()
        {
            MessageBox.Show("El personaje tomo un item", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            atacar();
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {
            defender();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            dormir();
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            tomarItem();
        }

        private void btnSoltar_Click(object sender, EventArgs e)
        {
            soltarItem();
        }
    }
}
