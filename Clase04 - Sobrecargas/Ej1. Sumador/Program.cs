using Librería_de_Clases;
using System;

namespace Ej1._Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador(5);

            Console.WriteLine(sumadorUno.Sumar(5, 7)); 
            Console.WriteLine(sumadorUno.Sumar(1, 4)); 
            Console.WriteLine(sumadorUno.Sumar(6, 2));
            Console.Write("\n\n");

            Console.WriteLine(sumadorDos.Sumar("hola", " chau"));
            Console.WriteLine(sumadorDos.Sumar("primer cadena, ", "segunda cadena"));
            Console.WriteLine(sumadorDos.Sumar("123", "456"));
            Console.Write("\n\n");

            Console.WriteLine( (int) sumadorUno);
            Console.WriteLine( (int) sumadorDos); //Devuelve 8 porque ya inicia en 5
            //Son conversiones explicitas porque aclaro que voy a realizar una conversión con el (int)
            Console.Write("\n\n");

            long suma = sumadorUno + sumadorDos;
            Console.WriteLine(suma);
            Console.Write("\n\n");

            Console.WriteLine(sumadorUno | sumadorDos);           
        }
    }
}