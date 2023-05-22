using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_numero
{
    public class Juego
    {
        public Jugador PrimerJugador { get; set; }
        public Jugador SegundoJugador { get; set; }
        public event EventHandler Ganador;

        public int Numero { get; set; }

        public Juego()
        {
            
        }
        public void CargarJugadores(string pPrimerNombre, string pSegundoNombre)
        {
            PrimerJugador = new Jugador(pPrimerNombre,1);
            SegundoJugador = new Jugador(pSegundoNombre,2);
        }
        public bool HayJugadores()
        {
            if(PrimerJugador==null || SegundoJugador == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string DeterminarGanador(int pNumero)
        {
            if (Numero > pNumero)
            {
                return $"{SegundoJugador.ToString()}, el numero ingresado es menor al que tiene que adivinar";
            }
            else if (Numero < pNumero)
            {
                return $"{SegundoJugador.ToString()}, el numero ingresado es mayor al que tiene que adivinar";
            }
            else
            {
                Ganador(this, new EventArgs());
                return $"¡Felicidades adivinaste el numero que ingreso {PrimerJugador.ToString()}!";
            }
        }
    }
}
