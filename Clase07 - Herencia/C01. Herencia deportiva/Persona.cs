using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01._Herencia_deportiva
{
    public abstract class Persona
    {
        private int dni;
        private string nombre;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(int dni, string nombre) :this(nombre)
        {
            Dni = dni;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {Dni}");

            return sb.ToString();
        }
    }
}
