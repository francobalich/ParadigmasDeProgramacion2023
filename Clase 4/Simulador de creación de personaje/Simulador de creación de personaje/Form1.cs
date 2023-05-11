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

namespace Simulador_de_creación_de_personaje
{
    public partial class Form1 : Form
    {
        private Personaje personaje;

        public Form1()
        {
            InitializeComponent();
        }
        private bool cargarHobbies(bool agregarHobbies)
        {
            while (agregarHobbies)
            {
                Hobbie nuevoHobbie = new Hobbie();
                string descripcion = Interaction.InputBox("Ingrese un hobbie del personaje.");
                nuevoHobbie.Descripcion = descripcion;
                personaje.agregarHobbie(nuevoHobbie);

                string resp = Interaction.InputBox("¿Desea agregar mas hobbies? (Y/n)");
                if (resp == "n")
                {
                    return false;
                }
            }
            return true;
        }
        private void crearPersonaje()
        {
            while (true)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del personaje.");

                string edadText = Interaction.InputBox("Ingrese la edad del personaje.");
                int edad = 0;
                bool success = int.TryParse(edadText, out edad);
                if (!success)
                {
                    MessageBox.Show("La edad tiene que ser un numero");
                }

                string alturaText = Interaction.InputBox("Ingrese la altura del personaje.");
                decimal altura = 0;
                success = decimal.TryParse(alturaText, out altura);
                if (!success)
                {
                    MessageBox.Show("La altura tiene que ser un numero");
                }
                string profesion = Interaction.InputBox("Ingrese la profesion del personaje.");

                personaje = new Personaje(nombre, edad, altura, profesion);

                bool agregarHobbies = true;
                agregarHobbies=cargarHobbies(agregarHobbies);
                if (!agregarHobbies)
                {
                    break;
                }
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Text=personaje.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblInfo.Text = "";
                personaje= null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                crearPersonaje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                crearPersonaje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
