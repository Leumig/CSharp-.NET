using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01._Herencia_deportiva
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private DirectorTecnico directorTecnico;
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre, DirectorTecnico directorTecnico) : this()
        {
            CantidadDeJugadores = cantidad;
            Nombre = nombre;
            jugadores.Capacity = CantidadDeJugadores;
            this.directorTecnico = directorTecnico;
        }

        public short CantidadDeJugadores { get => cantidadDeJugadores; set => cantidadDeJugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Jugador> ListaDeJugadores { get => jugadores; set => jugadores = value; }
        public DirectorTecnico DirectorTecnico { get => directorTecnico; set => directorTecnico = value; }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.ListaDeJugadores.Count < e.ListaDeJugadores.Capacity)
            {
                foreach (Jugador itemJugador in e.ListaDeJugadores)
                {
                    if(itemJugador.Dni == j.Dni)
                    {
                        return false;
                    }
                }
                e.ListaDeJugadores.Add(j);
                return true;
            }
            return false;
        }

        public static bool operator +(Equipo e, DirectorTecnico dt)
        {
            if (e.DirectorTecnico.FechaNacimiento == dt.FechaNacimiento)
            {
                return false;
            }

            e.DirectorTecnico = dt;
            return true;
        }
        public string EnlistarEquipo()
        {
            StringBuilder sb = new StringBuilder();

            int indice = 1;

            sb.AppendLine($"--- {Nombre} ---");

            foreach (var itemJugador in jugadores)
            {
                sb.AppendLine($"{indice}. {itemJugador.Nombre} [DNI: {itemJugador.Dni}]");
                indice++;
            }
            sb.AppendLine($"\nDT: {DirectorTecnico.Nombre} [{DirectorTecnico.FechaNacimiento.ToShortDateString()}]");

            return sb.ToString();
        }
    }
}
