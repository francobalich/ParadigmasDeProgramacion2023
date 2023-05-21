using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public class Comida : Item
    {
        public Comida(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public override string ToString()
        {
            return $"Comida: {Nombre}";
        }
    }
}
