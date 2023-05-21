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

namespace Creador_de_personajes
{
    public partial class Form1 : Form
    {
        private List<Personaje> personajes = new List<Personaje>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMago_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del mago");
                personajes.Add(new Mago(nombre, new Herramienta("Baston")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuerrero_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del guerrero");
                personajes.Add(new Guerrero(nombre, new Arma("Espada")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCrearHerrero_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del herrero");
                personajes.Add(new Herrero(nombre, new Comida("Pizza")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerPersonajes_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";
                if(personajes.Count > 0)
                {
                    foreach (Personaje personaje in personajes) {
                        mensaje+= personaje.ToString()+'\n';
                    }
                }
                else
                {
                    mensaje = "Aun no se agrego un personaje";
                }
                
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
