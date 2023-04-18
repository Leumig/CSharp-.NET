using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_deportivas
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            CantidadDeJugadores = cantidad;
            Nombre = nombre;
            jugadores.Capacity = CantidadDeJugadores;
        }

        public short CantidadDeJugadores { get => cantidadDeJugadores; set => cantidadDeJugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Jugador> ListaDeJugadores { get => jugadores; set => jugadores = value; }

        public static bool operator + (Equipo e, Jugador j)
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

            return sb.ToString();
        }
    }
}
