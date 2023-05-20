using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_horno
{
    public class Horno
    {
		private string elementoACocinar;
		private double temperatura;
        private double temperaturaDeCoccion;
        public event EventHandler<CoccionEventArgs> Coccion;

        public Horno()
        {
            
        }

        public Horno(string pElementoACocinar, double pTemperaturaDeCoccion)
        {
            this.elementoACocinar = pElementoACocinar;
            this.temperaturaDeCoccion = pTemperaturaDeCoccion;
        }

        public string ElementoACocinar
        {
            get { return this.elementoACocinar; }
            set { this.elementoACocinar = value; }
        }

        public double TemperaturaDeCoccion
        {
            get { return this.temperaturaDeCoccion; }
            set { this.temperaturaDeCoccion = value; }
        }
        public double Temperatura
		{
			get { return this.temperatura; }
			set { 
				this.temperatura = value;

                if (temperatura >= this.temperaturaDeCoccion)
                {
                    if (Coccion != null)
                    {
                        Coccion?.Invoke(this, new CoccionEventArgs(elementoACocinar, temperatura));
                    }
                }
            }
		}
	}
}
