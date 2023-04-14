using Librería_de_Clases;
using Librería_de_Clases_Validadoras;
using System;

namespace Ej4._Calculadora
{
    /*Ejercicio I04 - La calculadora
    Consigna
    Realizar un programa que permita realizar operaciones matemáticas
    simples (suma, resta, multiplicación y división).*/

    internal class Program
    {
        static void Main(string[] args)
        {
            string primerValorIngresado;
            string segundoValorIngresado;
            string tercerValorIngresado;
            int resultadoOperacion;
            string respuestaIngresada = "s";

            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                primerValorIngresado = Console.ReadLine();

                while (Validadora.EsNumerico(primerValorIngresado) == false)
                {
                    Console.WriteLine("Dato inválido. Reingrese el primer operando: ");
                    primerValorIngresado = Console.ReadLine();
                }

                Console.WriteLine("Ingrese el segundo operando: ");
                segundoValorIngresado = Console.ReadLine();

                while (Validadora.EsNumerico(segundoValorIngresado) == false)
                {
                    Console.WriteLine("Dato inválido. Reingrese el segundo operando: ");
                    segundoValorIngresado = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la operación que quiera hacer ( +, -, * o / ): ");
                tercerValorIngresado = Console.ReadLine();

                while (Validadora.ValidarOperacion(tercerValorIngresado) == false)
                {
                    Console.WriteLine("Dato inválido. Reingrese la operación ( +, -, * o / ): ");
                    tercerValorIngresado = Console.ReadLine();
                }

                int primerOperando = int.Parse(primerValorIngresado);
                int segundoOperando = int.Parse(segundoValorIngresado);

                try
                {
                    resultadoOperacion = Calculadora.Calcular(primerOperando, segundoOperando, tercerValorIngresado);
                    Console.WriteLine("El resultado es: {0}", resultadoOperacion);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Error, no se puede dividir por cero!");
                }

                Console.WriteLine("Ingrese 's' si desea continuar: ");
                respuestaIngresada = Console.ReadLine();

            } while (Validadora.ValidarRespuesta(respuestaIngresada));
        }
    }
}
