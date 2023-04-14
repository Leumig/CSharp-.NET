using Librería_de_Clases;
using System;

namespace Ej9._Calcular_un_factorial
{
    /*Ejercicio A01 - Calcular un factorial
    Consigna
    El factorial de un número es una operación que consiste en multiplicar
    un numero “n” por todos los números enteros positivos que estén debajo de él,
    por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            string valorIngresado = Console.ReadLine();

            int numeroIngresado = int.Parse(valorIngresado);

            int resultadoFactorial = Calculadora.CalcularFactorial(numeroIngresado);

            Console.WriteLine("El factorial de {0} es: {1}", numeroIngresado, resultadoFactorial);
        }
    }
}
