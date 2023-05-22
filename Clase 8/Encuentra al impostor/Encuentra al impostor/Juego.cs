using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuentra_al_impostor
{
    internal class Juego
    {
        private List<Jugador> jugadores = new List<Jugador>();
        private int vidas = 3;
        public event EventHandler ImpostorGanador;
        public event EventHandler InocenteGanador;

        public void AgregarJugador(Jugador pJugadores)
        {
            jugadores.Add(pJugadores);
        }
        private int generarNumeroRandom(int min, int max)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numero = genRandom.Next(min, max + 1);
            return numero;
        }

        public void CargarJugadores() 
        {
            AgregarJugador(new Inocente("Franco"));
            AgregarJugador(new Inocente("Juan"));
            AgregarJugador(new Inocente("Pedro"));
            AgregarJugador(new Inocente("Pablo"));

            int num = generarNumeroRandom(0, 3);

            jugadores[num] = new Impostor("Carlos");
        }
        private void ActualizarVidas(string pRol)
        {
            vidas -= 1;
            if (vidas < 2 && pRol!="Impostor")
            {
                ImpostorGanador(this, new EventArgs());
            }
        }
        public string ComprobarGanador(int pNumero)
        {
            var jugador = jugadores[pNumero-1];
            
            if (jugador.Rol == "Impostor")
            {
                ActualizarVidas(jugador.Rol);
                InocenteGanador(this, new EventArgs());
                return $"¡{jugador.ToString()} encontrado, felicidades!";
            }
            else
            {
                ActualizarVidas(jugador.Rol);
                return $"{jugador.ToString()} encontrado, siga buscando";
            }
        }
    }
}
