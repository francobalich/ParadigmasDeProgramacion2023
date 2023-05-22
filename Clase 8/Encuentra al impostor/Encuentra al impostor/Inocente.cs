using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuentra_al_impostor
{
    public class Inocente : Jugador
    {
        public Inocente(string pNombre) : base(pNombre)
        {
            base.Rol = "Inocente";
            base.Nombre = pNombre;
        }
    }
}
