using System;

namespace Ej3._Los_primos
{
    internal class Program
    {
        /*Consigna
        Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        Validar que el dato ingresado por el usuario sea un número.
        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        Si ingresa "salir", cerrar la consola.
        Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.*/    
        static void Main(string[] args)
        {
            string valorIngresadoString;
            float numeroIngresado;

            string codigoSalida = "salir";
            string continuarPrograma = "n";

            do
            {
                Console.WriteLine("Ingrese un número (o ingrese 'salir' para salir): ");
                valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = float.TryParse(valorIngresadoString, out numeroIngresado);

                while ((resultadoNumero == false || numeroIngresado <= 0) && valorIngresadoString != codigoSalida)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.WriteLine("Ingrese un número (o ingrese 'salir' para salir): ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = float.TryParse(valorIngresadoString, out numeroIngresado);
                }

                if (valorIngresadoString != codigoSalida)
                {
                    int numeroActual = 2;
                    int totalPrimosEncontrados = 1;

                    while (numeroActual <= numeroIngresado)
                    {
                        bool esPrimo = true;

                        for (int i = 2; i < numeroActual; i++)
                        {
                            if (numeroActual % i == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }

                        if (esPrimo)
                        {
                            Console.WriteLine(numeroActual);
                            totalPrimosEncontrados++;
                        }

                        numeroActual++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Si desea ingresar otro número, escriba 's': ");
                    continuarPrograma = Console.ReadLine();
                }

                if (valorIngresadoString == codigoSalida)
                {
                    continuarPrograma = "n";
                }

            } while (continuarPrograma == "s");
        }
    }
}
