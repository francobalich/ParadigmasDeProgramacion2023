using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuentra_al_impostor
{
    public class Impostor : Jugador
    {
        public Impostor(string pNombre) : base(pNombre)
        {
            base.Rol = "Impostor";
            base.Nombre = pNombre;
        }
    }
}
