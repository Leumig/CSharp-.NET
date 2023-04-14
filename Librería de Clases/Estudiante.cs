using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    //Esta clase corresponde al ejercicio 'El ejemplo universal'
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        private float CalcularPromedio()
        {
            return (float) (NotaPrimerParcial + NotaSegundoParcial) / 2;
        }

        private int CalcularNotaFinal()
        {
            int notaFinal = -1;

            if(NotaPrimerParcial >= 4 && NotaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }

            return notaFinal;
        }
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            int notaFinal = CalcularNotaFinal();

            sb.AppendLine("========================================================================");
            sb.AppendLine($"|| NOMBRE: {Nombre} || APELLIDO: {Apellido} || " +
                $"LEGAJO: {Legajo} ||");
            sb.AppendLine($"|| NOTA PRIMER PARCIAL: {NotaPrimerParcial} || NOTA SEGUNDO PARCIAL: {NotaSegundoParcial} ||");
            sb.AppendLine($"|| PROMEDIO: {CalcularPromedio()} ||");

            if (notaFinal != -1)
            {
                sb.AppendLine($"|| NOTA FINAL: {notaFinal} ||");
            }else
            {
                sb.AppendLine(" --- ALUMNO DESAPROBADO --- ");
            }

            return sb.ToString();
        }     
    }
}
