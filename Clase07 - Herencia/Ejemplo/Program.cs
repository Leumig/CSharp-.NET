using Biblioteca_de_clases;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona personaUno = new Persona("Juan", "Perez", 666); 
            //Ahora que hicimos que la clase Persona sea abstract, esto va a dar error.
            
            //Persona personaDos = new Persona("Miguel", "Gil", -1);

            //Console.WriteLine(personaUno.ToString());
            //Console.WriteLine(personaDos.ToString());

            Alumno alumnoUno = new Alumno("Lucia", "Lopez", 43584712, 3);

            Console.WriteLine(alumnoUno.ToString());

            Console.WriteLine("============================================");
            Console.WriteLine(alumnoUno.Saludar());



        }
    }
}