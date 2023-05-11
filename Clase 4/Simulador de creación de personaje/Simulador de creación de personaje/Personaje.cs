using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_creación_de_personaje
{
    public class Personaje
    {
		private string nombre;
		private int edad;
		private decimal altura;
		private string profesion;
		private List<Hobbie> hobbies = new List<Hobbie>();

        public Personaje(string pNombre, int pEdad, decimal pAltura, string pProfesion)
        {
			this.nombre = pNombre;
			this.edad = pEdad;
			this.altura = pAltura;
			this.profesion = pProfesion;
        }
        ~Personaje()
        {
            this.nombre = "";
            this.edad = 0;
            this.altura = 0;
            this.profesion = "";
            hobbies.Clear();
        }
        public void agregarHobbie(Hobbie pHobbie)
		{
			hobbies.Add(pHobbie);
		}
        public override string ToString()
        {
			string hobbiesText = "Tiene de hobbies ";
			if(hobbies.Count > 0)
			{
				foreach (Hobbie item in hobbies)
				{
					hobbiesText += item.Descripcion + ", ";
                }
			}
			else
			{
                hobbiesText = "No tiene de hobbies";
            }
			string edadText = "una cantidad desconocida de";
			if(this.edad > 0)
			{
				edadText=this.edad.ToString();
			}
            string alturaText = "una altura desconocida en ";
            if (this.altura > 0)
            {
                alturaText = this.altura.ToString();
            }
            return $"{this.nombre}" +
				$"\nTiene {edadText} años."+
				$"\nMide {alturaText}m" +
				$"\nEs un {this.profesion}" +
				$"\n{hobbiesText}";
        }
    }
}
