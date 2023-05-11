using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_inventario
{
    public class Inventario
    {   
        private List<Espada> espadas = new List<Espada>();
        private List<Pico> picos = new List<Pico>();
        private List<Mesa> mesas = new List<Mesa>();
        private List<Cama> camas = new List<Cama>();

        public Inventario() { }

        public void AgregarEspada(string pNombre)
        {
            Espada item = new Espada(pNombre);
            espadas.Add(item);
        }
        public void AgregarPico(string pNombre)
        {
            Pico item = new Pico(pNombre);
            picos.Add(item);
        }
        public void AgregarMesa(string pNombre)
        {
            Mesa item = new Mesa(pNombre);
            mesas.Add(item);
        }
        public void AgregarCama(string pNombre)
        {
            Cama item = new Cama(pNombre);
            camas.Add(item);
        }
        public override string ToString()
        {
            string espadasText = "Espadas: ";
            string picosText = "Picos: ";
            string mesasText = "Mesas: ";
            string camasText = "Camas: ";

            foreach (var item in espadas)
            {
                espadasText += item.Nombre + ", ";
            }
            foreach (var item in picos)
            {
                picosText += item.Nombre + ", ";
            }
            foreach (var item in mesas)
            {
                mesasText += item.Nombre + ", ";
            }
            foreach (var item in camas)
            {
                camasText += item.Nombre + ", ";
            }

            return $"Se tienen {espadas.Count} espadas, {picos.Count} picos, {mesas.Count} mesas y {camas.Count} camas.\n{espadasText}\n{picosText}\n{mesasText}\n{camasText}";
        }
        private class Espada
        {
            private string nombre;

            public Espada(string pNombre) 
            { 
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
        private class Pico
        {
            private string nombre;

            public Pico(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
        private class Mesa
        {
            private string nombre;

            public Mesa(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
        private class Cama
        {
            private string nombre;

            public Cama(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
    }
}
