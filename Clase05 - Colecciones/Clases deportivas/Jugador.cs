using System.Data.Common;
using System.Text;

namespace Clases_deportivas
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;  //El ejercicio C01 de Encapsulamiento nos pide sacar este atributo.
        private int totalGoles;

        private Jugador()
        {
            Dni = 0;
            Nombre = "NO CARGADO";
            partidosJugados = 0;
            //promedioGoles = 0;  //El ejercicio C01 de Encapsulamiento nos pide sacar este atributo.
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre) :this()
        {
            Dni = dni;
            Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PartidosJugados { get => partidosJugados;}
        public int TotalGoles { get => totalGoles; }
        public float PromedioGoles { get => (float) TotalGoles / PartidosJugados; }


        /*public float GetPromedioGoles()    //El ejercicio C01 de Encapsulamiento nos pide sacar este método y usarlo en la propiedad.
        {
            return (float) TotalGoles / PartidosJugados;
        }*/

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Goles en total: {TotalGoles}");
            sb.AppendLine($"Promedio de goles: {PromedioGoles.ToString("0.00")}");

            return sb.ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
}