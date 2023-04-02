using System;
using System.Runtime.Intrinsics.Arm;

namespace Apunte_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro un array, en este caso de strings
            string[] nombres = new string[3];

            //Los arrays NO pueden modificar su tamaño

            //Cargo valores de forma secuencial
            nombres[0] = "Lucas";
            nombres[1] = "Juan";
            nombres[2] = "Nacho";

            //Muestro
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            //Otra forma de declarar
            string[] paises = { "Brasil", "Peru", "Argentina" };

            //Muestro
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

            //Otra forma de mostrar
            foreach (string itemPais in paises) //Itero sobre el array 'paises' y guardo cada valor en 'itemPais'
            {
                Console.WriteLine(itemPais);
            }
            //El foreach recorre todo el array hasta el final


            //Declaro un array, en este caso de numeros
            int[] numeros = new int[10];
            numeros[0] = 5;
            numeros[1] = 25;
            numeros[2] = 1;
            numeros[3] = 10;
            numeros[4] = 35;
            //Los lugares no asignados, quedan en '0', que es el estado nulo predeterminado de los int

            //Muestro
            foreach (var itemNumero in numeros)
            {
                Console.WriteLine(itemNumero);
            }

            string[] animales = new string[4]; 

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Escribí un animal: ");
                animales[i] = Console.ReadLine();
            }
            //Pido que el usuario ingrese animales

            Console.WriteLine("Los animales ingresados son:");
            foreach (var itemAnimal in animales)
            {
                Console.WriteLine(itemAnimal);
            }
            //Muestro el array de animales
        }
    }
}
