using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public class Mago:Personaje
    {
        private string nombre = "";
        private string profesion = "Mago";

        public Mago(string pNombre)
        {
            this.nombre = pNombre;
        }

        public override string Nombre { get => this.nombre; set => this.nombre = value; }
        public override string Profesion { get => this.profesion; }
    }
}
