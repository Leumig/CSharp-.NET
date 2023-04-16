using Librería_de_Clases;
using System;

namespace Billete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar cantidadDolar = new Dolar(100, 1);
            Euro cantidadEuro = new Euro(100, 1.17);
            Pesos cantidadPesos = new Pesos(100, 102.65);

            var resultado1 = (Dolar)cantidadDolar;
            var resultado2 = (Dolar)cantidadEuro;
            var resultado3 = (Dolar)cantidadPesos;

            var resultado4 = (Euro)cantidadDolar;
            var resultado5 = (Euro)cantidadEuro;
            var resultado6 = (Euro)cantidadPesos;

            var resultado7 = (Pesos)cantidadDolar;
            var resultado8 = (Pesos)cantidadEuro;
            var resultado9 = (Pesos)cantidadPesos;

            Console.WriteLine("Cantidad de Dolares necesarios:");
            Console.WriteLine($"Para 100 Dolares: {resultado1.GetCantidad()}");
            Console.WriteLine($"Para 100 Euros: {resultado2.GetCantidad()}");
            Console.WriteLine($"Para 100 Pesos: {resultado3.GetCantidad()}");
            Console.WriteLine("\n\n");

            Console.WriteLine("Cantidad de Euros necesarios:");
            Console.WriteLine($"Para 100 Dolares: {resultado4.GetCantidad()}");
            Console.WriteLine($"Para 100 Euros: {resultado5.GetCantidad()}");
            Console.WriteLine($"Para 100 Pesos: {resultado6.GetCantidad()}");
            Console.WriteLine("\n\n");

            Console.WriteLine("Cantidad de Pesos necesarios");
            Console.WriteLine($"Para 100 Dolares: {resultado7.GetCantidad()}");
            Console.WriteLine($"Para 100 Euros: {resultado8.GetCantidad()}");
            Console.WriteLine($"Para 100 Pesos: {resultado9.GetCantidad()}");
        }
    }
}