using Librería_de_Clases_Validadoras;
using System;

namespace Ej2._Desea_Continuar
{
    /*Ejercicio I02 - ¿Desea continuar?
    Consigna
    Realizar un programa que sume números enteros hasta que el usuario lo determine
    por medio de un mensaje "¿Desea continuar? (S/N)".
    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE
    si se ingresó cualquier otro valor.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaIngresada = "s";
            int acumuladorNumeros = 0;

            while (Validadora.ValidarRespuesta(respuestaIngresada) == true)
            {
                Console.WriteLine("Ingrese un número: ");
                string valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = int.TryParse(valorIngresadoString, out int numeroIngresado);

                while (resultadoNumero == false)
                {
                    Console.WriteLine("Dato inválido");
                    Console.WriteLine("Ingrese un número: ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = int.TryParse(valorIngresadoString, out numeroIngresado);
                }

                acumuladorNumeros += numeroIngresado;

                Console.WriteLine("¿Desea continuar ? (S / N)");
                respuestaIngresada = Console.ReadLine();
            }

            Console.WriteLine("La suma de todos los números es: " + acumuladorNumeros);
        }
    }
}
