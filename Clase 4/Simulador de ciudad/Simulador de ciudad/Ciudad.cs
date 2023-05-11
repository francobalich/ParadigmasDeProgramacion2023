using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_ciudad
{
    public class Ciudad
    {
        private List<Construccion> construcciones = new List<Construccion>();
        private List<Calle> calles = new List<Calle>();
        private List<Monumento> monumentos = new List<Monumento>();

        public Ciudad() { }

        public void AgregarConstruccion(string pNombre)
        {
            Construccion item = new Construccion(pNombre);
            construcciones.Add(item);
        }
        public void AgregarCalle(string pNombre)
        {
            Calle item = new Calle(pNombre);
            calles.Add(item);
        }
        public void AgregarMonumento(string pNombre)
        {
            Monumento item = new Monumento(pNombre);
            monumentos.Add(item);
        }
        public override string ToString()
        {
            return  $"Construcciones: {construcciones.Count}." +
                    $"\nCalles: {calles.Count}." +
                    $"\nMonumentos: {monumentos.Count}.";
        }
        
        private class Construccion
        {
            private string nombre;

            public Construccion(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
        private class Calle
        {
            private string nombre;

            public Calle(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
        private class Monumento
        {
            private string nombre;

            public Monumento(string pNombre)
            {
                this.nombre = pNombre;
            }
            public string Nombre { get { return nombre; } }
        }
    }
}
