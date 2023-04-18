using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01._Herencia_deportiva
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) :this(nombre)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public static bool operator != (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1.FechaNacimiento == dt2.FechaNacimiento && dt1.Nombre == dt2.Nombre);
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.FechaNacimiento == dt2.FechaNacimiento && dt1.Nombre == dt2.Nombre;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}");
            //sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("d")}");
            //Funcionan igual ambas formas. El ToString muestra una forma detallada de cómo se vería.

            return sb.ToString();
        }
    }
}
