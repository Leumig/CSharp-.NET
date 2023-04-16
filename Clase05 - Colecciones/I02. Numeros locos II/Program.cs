namespace I02._Numeros_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;
            int i = 0;

            List<int> listaDeNumeros = new List<int>();
            Stack<int> stackDeNumeros = new Stack<int>();
            Queue<int> queueDeNumeros = new Queue<int>();


            while (i < 20)
            {
                numero = random.Next(-100, 100);

                if (numero != 0)
                {
                    listaDeNumeros.Add(numero);
                    stackDeNumeros.Push(numero);
                    queueDeNumeros.Enqueue(numero);
                    i++;
                }
            }

            Console.WriteLine("Números");

            /*foreach (var itemLista in listaDeNumeros)
            {               
                Console.WriteLine(itemLista);
            }*/

            /*foreach (var itemStack in stackDeNumeros)
            {
                Console.WriteLine(itemStack);
            }*/

            foreach (var itemQueue in queueDeNumeros)
            {
                Console.WriteLine(itemQueue);
            }

            Console.WriteLine("\n\nNúmeros positivos (orden decreciente)");

            listaDeNumeros.Sort((numeroUno, numeroDos) =>
            {
                return numeroDos.CompareTo(numeroUno);
            });

            foreach (var itemLista in listaDeNumeros)
            {
                if (itemLista > 0)
                {
                    Console.WriteLine(itemLista);
                }
            }
          
            Console.WriteLine("\n\nNúmeros negativos (orden creciente)");

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