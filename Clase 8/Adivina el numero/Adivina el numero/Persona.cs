using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_numero
{
    public abstract class Persona
    {
        private string nombre = "Sin nombre";

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            return $"{nombre}";
        }
    }
}
