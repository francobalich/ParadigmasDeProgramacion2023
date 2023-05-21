using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_personajes
{
    public class Herrero : Personaje
    {
        private string nombre = "";
        private string profesion = "Herrero";

        public Herrero(string pNombre, Item pItem)
        {
            this.nombre = pNombre;
            this.ItemPoseido = pItem;
        }

        public override string Nombre { get => this.nombre; set => this.nombre = value; }
        public override string Profesion { get => this.profesion; }
    }
}
