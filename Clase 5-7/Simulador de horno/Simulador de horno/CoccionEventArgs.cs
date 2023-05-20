using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_horno
{
    public class CoccionEventArgs : EventArgs
    {
        private double temperatura;
        private string elemento;

        public double Temperatura
        {
            get { return this.temperatura; }
            set { this.temperatura = value; }
        }
        public string Elemento
        {
            get { return this.elemento; }
            set { this.elemento = value; }
        }

        public CoccionEventArgs(string pElemento, double pTemperatura)
        {
            this.elemento = pElemento; 
            this.temperatura = pTemperatura;
        }
    }
}
