using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuentra_al_impostor
{
    public abstract class Jugador
    {
        private string nombre = "Sin nombre";
        private string rol = "Sin rol";
        private int id=0;

        public Jugador()
        {
            
        }
        public Jugador(string pNombre)
        {
            this.nombre = pNombre;
        }
        public Jugador(int pId)
        {
            this.id = pId;
        }
        public string Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public override string ToString()
        {
            return $"{this.nombre} ({this.rol})";
        }
    }
}
