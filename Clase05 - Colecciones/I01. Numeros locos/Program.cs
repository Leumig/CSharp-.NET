using System.Collections.Immutable;

namespace I01._Numeros_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> listaDeNumeros = new List<int>();

            for(int i = 0; i < 20; i++)
            {
                listaDeNumeros.Add(random.Next(-100, 100));
            }
            
            foreach (var itemLista in listaDeNumeros)
            {
                Console.WriteLine(itemLista);
            }

            Console.WriteLine("=====================");
            Console.WriteLine("=====================");

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

            Console.WriteLine("=====================");
            Console.WriteLine("=====================");

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