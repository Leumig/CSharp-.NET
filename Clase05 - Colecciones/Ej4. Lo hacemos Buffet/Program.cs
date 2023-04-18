using Librería_de_Clases_Validadoras;
using Librería_de_Clases;
using System;
using System.Collections.Generic;

namespace Ej4._Lo_hacemos_Buffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoIngresadoString = "";
            int opcionIngresada = 0;

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            //Creo la fila
            Queue<string> filaClientes = new Queue<string>();
            filaClientes.Enqueue("Miguel");
            filaClientes.Enqueue("Santiago");
            filaClientes.Enqueue("Emmanuel");
            filaClientes.Enqueue("Federico");
            filaClientes.Enqueue("Juan");
            filaClientes.Enqueue("Carlos");
            filaClientes.Enqueue("Roberto");
            filaClientes.Enqueue("Ivan");

            //Creo la lista de productos para el Buffet
            List<Producto> mesaBuffet = new List<Producto>();

            //Creo los productos
            Producto productoPizza = new Producto("Pizza", 600);
            Producto productoHamburguesa = new Producto("Hamburguesa", 500);
            Producto productoFideos = new Producto("Fideos", 450);
            Producto productoMilanesa = new Producto("Milanesa", 400);
            Producto productoPancho = new Producto("Pancho", 350);
            Producto productoAgua = new Producto("Agua", 200);
            Producto productoGaseosa = new Producto("Gaseosa", 250);
            Producto productoJugo = new Producto("Jugo", 300);
            Producto productoCerveza = new Producto("Cerveza", 400);
            Producto productoSoda = new Producto("Soda", 250);

            //Le agrego los productos a la lista del Buffet
            #region Productos agregados
            mesaBuffet.Add(productoPizza);
            mesaBuffet.Add(productoPizza);
            mesaBuffet.Add(productoPizza);
            mesaBuffet.Add(productoHamburguesa);
            mesaBuffet.Add(productoHamburguesa);
            mesaBuffet.Add(productoHamburguesa);
            mesaBuffet.Add(productoHamburguesa);
            mesaBuffet.Add(productoHamburguesa);
            mesaBuffet.Add(productoFideos);
            mesaBuffet.Add(productoFideos);
            mesaBuffet.Add(productoFideos);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoMilanesa);
            mesaBuffet.Add(productoPancho);
            mesaBuffet.Add(productoPancho);
            mesaBuffet.Add(productoPancho);
            mesaBuffet.Add(productoPancho);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoAgua);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoGaseosa);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoJugo);
            mesaBuffet.Add(productoCerveza);
            mesaBuffet.Add(productoCerveza);
            mesaBuffet.Add(productoCerveza);
            mesaBuffet.Add(productoCerveza);
            mesaBuffet.Add(productoSoda);
            mesaBuffet.Add(productoSoda);
            mesaBuffet.Add(productoSoda);
            mesaBuffet.Add(productoSoda);
            #endregion

            //Creo una lista de los productos que va seleccionando cada cliente
            List<Producto> listaPedidoDelCliente = new List<Producto>();

            while (mesaBuffet.Count > 0 && filaClientes.Count > 0 && datoIngresadoString != "s" && datoIngresadoString != "S")
            {
                string clienteActual = filaClientes.Peek();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"El cliente actual es {clienteActual} y atrás hay {filaClientes.Count - 1} personas más");
                Console.ResetColor();

                int indice = 1;
                foreach (Producto itemProducto in mesaBuffet)
                {
                    Console.WriteLine($"{indice}) Producto: {itemProducto.Nombre} | " +
                        $"Precio: {itemProducto.Precio} | Cantidad: {mesaBuffet[indice]} |");
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

                if (filaClientes.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ya no hay más clientes!\n ");
                    Console.ResetColor();

                    while (datoIngresadoString != "S" && datoIngresadoString != "s")
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

                        if (datoIngresadoString != "S" && datoIngresadoString != "s")
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
