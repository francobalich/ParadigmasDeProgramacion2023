using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Simulador_de_inventario
{
    public partial class Form1 : Form
    {
        private Inventario inventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inventario.ToString());
        }

        private void btnAgregarEspada_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la espada");
            inventario.AgregarEspada(nombre);
        }

        private void btnAgregarPico_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del pico");
            inventario.AgregarPico(nombre);
        }
        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la mesa");
            inventario.AgregarMesa(nombre);
        }

        private void btnAgregarCama_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la cama");
            inventario.AgregarCama(nombre);
        }
    }
}
