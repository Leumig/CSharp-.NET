using System.Collections.Immutable;

namespace I01._Numeros_locos
{
    /*Ejercicio I01 - Números locos
    Consigna
    Crear una aplicación de consola que cargue 20 números enteros
    (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;
            int i = 0;

            List<int> listaDeNumeros = new List<int>();

            while(i < 20)
            {
                numero = random.Next(-10, 10);
                if(numero != 0)
                {
                    listaDeNumeros.Add(numero);
                    i++;
                }
            }

            Console.WriteLine("Lista de números");

            foreach (var itemLista in listaDeNumeros)
            {
                Console.WriteLine(itemLista);
            }

            Console.WriteLine("\n\nLista de números positivos (orden decreciente)");

            listaDeNumeros.Sort((numeroUno, numeroDos) =>
            {
                return numeroDos.CompareTo(numeroUno);
            });

            foreach (var itemLista in listaDeNumeros)
            {
                if(itemLista > 0)
                {
                    Console.WriteLine(itemLista);
                }
            }

            Console.WriteLine("\n\nLista de números negativos (orden creciente)");

            listaDeNumeros.Sort((numeroUno, numeroDos) =>
            {
                return numeroUno.CompareTo(numeroDos);
            });

            foreach (var itemLista in listaDeNumeros)
            {
                if (itemLista < 0)
                {
                    Console.WriteLine(itemLista);
                }
            }
        }
    }
}