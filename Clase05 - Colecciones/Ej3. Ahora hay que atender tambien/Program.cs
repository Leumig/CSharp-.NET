using Librería_de_Clases;
using Librería_de_Clases_Validadoras;
using System;
using System.Collections.Generic;

namespace Ej3._Ahora_hay_que_atender_tambien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoIngresadoString = "";
            int opcionIngresada = 0;

            //Creo las fila
            Queue<string> filaClientes = new Queue<string>();
            filaClientes.Enqueue("Migue");
            filaClientes.Enqueue("Soru");
            filaClientes.Enqueue("Emma");
            filaClientes.Enqueue("Fede");
            filaClientes.Enqueue("Juan");
            filaClientes.Enqueue("Carlos");
            filaClientes.Enqueue("Roberto");
            filaClientes.Enqueue("Ivan");

            //Creo las pilas (Stacks)
            Stack<Producto> Cheetos = new Stack<Producto>();
            Stack<Producto> Doritos = new Stack<Producto>();
            Stack<Producto> Twistos = new Stack<Producto>();

            //Creo un producto por cada stack y lo pusheo varias veces al stack que le corresponde
            Producto productoCheetos = new Producto("Cheetos", 150);
            Cheetos.Push(productoCheetos);
            Cheetos.Push(productoCheetos);
            Cheetos.Push(productoCheetos);
            Cheetos.Push(productoCheetos);
            Cheetos.Push(productoCheetos);
            Producto productoDoritos = new Producto("Doritos", 120);
            Doritos.Push(productoDoritos);
            Doritos.Push(productoDoritos);
            Doritos.Push(productoDoritos);
            Doritos.Push(productoDoritos);
            Doritos.Push(productoDoritos);
            Producto productoTwistos = new Producto("Twistos", 170);
            Twistos.Push(productoTwistos);
            Twistos.Push(productoTwistos);
            Twistos.Push(productoTwistos);
            Twistos.Push(productoTwistos);
            Twistos.Push(productoTwistos);
            Twistos.Push(productoTwistos);

            //Creo el dictionary de la máquina
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            //Le agrego las 3 pilas al dictionary (a la máquina)
            maquinaExpendedora.Add(1, Cheetos);
            maquinaExpendedora.Add(2, Doritos);
            maquinaExpendedora.Add(3, Twistos);

            while (maquinaExpendedora.Count > 0 && filaClientes.Count > 0 && datoIngresadoString != "s" && datoIngresadoString != "S")
            {
                string clienteActual = filaClientes.Peek();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"El cliente actual es {clienteActual} y atrás hay {filaClientes.Count-1} personas más");
                Console.ResetColor();

                foreach (KeyValuePair<int, Stack<Producto>> itemStack in maquinaExpendedora)
                {
                    Console.WriteLine($"{itemStack.Key}) Producto: {itemStack.Value.Peek().Nombre} | " +
                        $"Precio: {itemStack.Value.Peek().Precio} | Cantidad: {itemStack.Value.Count} |");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nIngrese el número del producto que quiere comprar (o ingrese 'S' para Salir): ");
                Console.ResetColor();

                datoIngresadoString = Console.ReadLine();

                if (int.TryParse(datoIngresadoString, out opcionIngresada) && maquinaExpendedora.ContainsKey(opcionIngresada))
                {
                    filaClientes.Dequeue();

                    Producto productoSeleccionado = maquinaExpendedora[opcionIngresada].Pop();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nUsted seleccionó: {productoSeleccionado.Nombre}" +
                        $" (${productoSeleccionado.Precio}) [{productoSeleccionado.Codigo}]\n");
                    Console.ResetColor();
                    if (maquinaExpendedora[opcionIngresada].Count == 0)
                    {
                        maquinaExpendedora.Remove(opcionIngresada);
                    }
                }
                else if (datoIngresadoString != "s" && datoIngresadoString != "S")
                {
                    Console.WriteLine("Error! Ingrese una opción válida!");
                    datoIngresadoString = Console.ReadLine();
                }

                if(filaClientes.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ya no hay más clientes!\n ");
                    Console.ResetColor();

                    while(datoIngresadoString != "S" && datoIngresadoString != "s")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Ingrese el nombre de un nuevo cliente para agregarlo a la cola, o 'S' para salir");
                        Console.ResetColor();
                        datoIngresadoString = Console.ReadLine();

                        while (Validadora.ValidarStringNombre(datoIngresadoString))
                        {
                            Console.WriteLine("Error! Ingrese un nombre correcto: ");
                            datoIngresadoString = Console.ReadLine();
                        }

                        if(datoIngresadoString != "S" && datoIngresadoString != "s")
                        {
                            filaClientes.Enqueue(datoIngresadoString);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cliente agregado a la cola");
                            Console.ResetColor();
                        }
                    }
                    datoIngresadoString = "";
                }

            }

            if (maquinaExpendedora.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se terminaron todos los productos!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Fin del programa");
            }
        }
    }
}
