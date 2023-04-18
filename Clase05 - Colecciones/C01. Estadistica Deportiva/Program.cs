using Clases_deportivas;

namespace C01._Estadistica_Deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipoUno = new Equipo(5, "Boca Juniors");

            Jugador jugadorUno = new Jugador(43596276, "Miguel", 17, 13);
            Jugador jugadorDos = new Jugador(45988146, "Juan", 1, 1);
            Jugador jugadorTres = new Jugador(42511008, "Carlos", 10, 27);
            Jugador jugadorCuatro = new Jugador(43177169, "Jorge", 22, 35);
            Jugador jugadorCinco = new Jugador(43596276, "Cristian", 6, 7); //Tiene el mismo DNI que jugadorUno

            Console.WriteLine(jugadorUno.MostrarDatos());
            Console.WriteLine(jugadorDos.MostrarDatos());
            Console.WriteLine(jugadorTres.MostrarDatos());
            Console.WriteLine(jugadorCuatro.MostrarDatos());

            if(equipoUno + jugadorUno)
            {
                Console.WriteLine("Se agregó un jugador");
            }

            if(equipoUno + jugadorDos)
            {
                Console.WriteLine("Se agregó otro jugador");
            }
            
            if(equipoUno + jugadorTres)
            {
                Console.WriteLine("Se agregó un tercer jugador");
            }

            if(!(equipoUno + jugadorCinco))
            {
                Console.WriteLine("No se agregó a este jugador porque ya existe ese DNI\n\n");
            }

            Console.WriteLine(equipoUno.EnlistarEquipo());

            /*if(jugadorUno == jugadorCinco)
            {
                Console.WriteLine("Son el mismo jugador.");
            }
            else
            {
                Console.WriteLine("No son el mismo jugador.");
            }*/
        }
    }
}