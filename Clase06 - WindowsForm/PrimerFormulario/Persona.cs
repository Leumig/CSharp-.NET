using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerFormulario
{
    public class Persona
    {
        private string nombre;
        private int legajo;
        
        public Persona()
        {
            Nombre = "NO CARGADO";
            Legajo = 0000;
        }
        public Persona(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"NOMBRE: {Nombre} || LEGAJO: {Legajo}");

            return sb.ToString();
        }

    }
}
