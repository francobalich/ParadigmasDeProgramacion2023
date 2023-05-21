using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public class Herramienta : Item
    {
        public Herramienta(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public override string ToString()
        {
            return $"Herramienta: {Nombre}";
        }
    }
}
