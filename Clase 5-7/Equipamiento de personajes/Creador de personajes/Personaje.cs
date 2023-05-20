using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public abstract class Personaje
    {
        public abstract string Nombre { get; set; }
        public abstract string Profesion { get; }

        public override string ToString()
        {
            return $"{Nombre} ({Profesion})";
        }
    }
}
