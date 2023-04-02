using System;
using System.Text;
using static Ej1._Sobre_sobrescribiendo_esas_advertencias.Program;

namespace Ej1._Sobre_sobrescribiendo_esas_advertencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobreescrito objetoSobrescrito = new Sobreescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
        }

        public class Sobreescrito
        {
            protected string miAtributo;

            public Sobreescrito(string miAtributo)
            {
                this.miAtributo = "Probar abstractos";
            }

            abstract string MiPropiedad
            {

            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("¡Este es mi método ToString sobrescrito!");

                return sb.ToString();
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);    
            }

            public override int GetHashCode()
            {
                return 1142510181;
            }









        }

        






    }
}
