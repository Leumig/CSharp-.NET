using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01._Herencia_deportiva
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;


        public Jugador(int dni, string nombre) :base(nombre)
        {
            Dni = dni;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :base(dni, nombre)
        {
            TotalGoles = totalGoles;
            PartidosJugados = totalPartidos;
        }

        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }
        public float PromedioGoles { get => (float)TotalGoles / PartidosJugados; }


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

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
}
