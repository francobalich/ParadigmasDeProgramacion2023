using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_personaje
{
    public class Personaje
    {
        private string nombre="";

        public Personaje(string pNombre) 
        {
            this.nombre = pNombre;
        }

        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }

        public void atacar()
        {
            int daño = generarNumeroRandom(100, 1000);
            MessageBox.Show($"{this.nombre} ataco con " + daño.ToString() + " de daño.", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void defender()
        {
            int resultado = generarNumeroRandom(0, 1);
            if (resultado == 1)
            {
                MessageBox.Show($"{this.nombre} se defendio correctamente", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{this.nombre} no se pudo defender.", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void dormir()
        {
            MessageBox.Show($"{this.nombre} se durmio", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void soltarItem(string pItem)
        {
            MessageBox.Show($"{this.nombre} solto un {pItem}", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void tomarItem(string pItem)
        {
            MessageBox.Show($"{this.nombre} tomo un {pItem}", "Accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
