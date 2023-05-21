using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public abstract class Item
    {
        public string Nombre { get; set; }
        public abstract override string ToString();
    }
}
