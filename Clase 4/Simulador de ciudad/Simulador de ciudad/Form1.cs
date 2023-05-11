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

namespace Simulador_de_ciudad
{
    public partial class Form1 : Form
    {
        private Ciudad ciudad = new Ciudad();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgragarConstruccion_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la construccion:");
            ciudad.AgregarConstruccion(nombre);
        }

        private void btnAgregarCalle_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la calle:");
            ciudad.AgregarMonumento(nombre);
        }

        private void btnAgregarMonumento_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del monumento:");
            ciudad.AgregarMonumento(nombre);
        }

        private void btnVerCantidades_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ciudad.ToString());
        }
    }
}
