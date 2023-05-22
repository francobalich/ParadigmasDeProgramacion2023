using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_numero
{
    public class Jugador:Persona
    {
        public int Numero { get; set; }

        public Jugador(string pNombre, int pNumero)
        {
            Nombre = pNombre;
            Numero = pNumero;
        }

        public override string ToString()
        {
            return $"Jugador {Numero}: {Nombre}";
        }
    }
}
