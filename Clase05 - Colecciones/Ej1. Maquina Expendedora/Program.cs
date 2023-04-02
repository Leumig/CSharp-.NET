using Librería_de_Clases;
using System;
using System.Collections.Generic;  //Hay que usarlo para las colecciones genéricas (en este caso Dictionary)

namespace Ej1._Maquina_Expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaIngresada;
            
            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

            //Con #region y #endregion puedo hacer esto por ejemplo:
            #region Instancia de Productos
            Producto producto1 = new Producto("Coca-Cola", 150);
            Producto producto2 = new Producto("Pepsi", 150);
            Producto producto3 = new Producto("Fanta", 130);
            Producto producto4 = new Producto("Seven Up", 130);
            Producto producto5 = new Producto("Sprite", 130);
            Producto producto6 = new Producto("Lays", 150);
            Producto producto7 = new Producto("Cheetos", 150);
            Producto producto8 = new Producto("Doritos", 120);
            Producto producto9 = new Producto("Twistos", 150);
            Producto producto10 = new Producto("Saladix", 80);
            #endregion

            #region Agregado de Productos
            maquinaExpendedora.Add(1, producto1);
            maquinaExpendedora.Add(2, producto2);
            maquinaExpendedora.Add(3, producto3);
            maquinaExpendedora.Add(4, producto4);
            maquinaExpendedora.Add(5, producto5);
            maquinaExpendedora.Add(6, producto6);
            maquinaExpendedora.Add(7, producto7);
            maquinaExpendedora.Add(8, producto8);
            maquinaExpendedora.Add(9, producto9);
            maquinaExpendedora.Add(10, producto10);
            #endregion

            do
            {
                foreach (KeyValuePair<int, Producto> itemProducto in maquinaExpendedora)
                {
                    Console.WriteLine($"{itemProducto.Key}) {itemProducto.Value.Nombre} (${itemProducto.Value.Precio})");
                    //Console.WriteLine("{0}- {1}", itemProducto.Key, itemProducto.Value); // Otra forma de hacer el CW.
                }

                Console.WriteLine("\nIngrese el número del producto que quiere comprar: ");

                string datoIngresado = Console.ReadLine();
                bool datoIngresadoValido = int.TryParse(datoIngresado, out int opcionIngresada);

                while (!maquinaExpendedora.ContainsKey(opcionIngresada))
                {
                    Console.WriteLine("Error! Ingrese una opción válida: ");
                    datoIngresado = Console.ReadLine();
                    datoIngresadoValido = int.TryParse(datoIngresado, out opcionIngresada);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nUsted seleccionó el producto: {maquinaExpendedora[opcionIngresada].Nombre}" +
                                    $" (${maquinaExpendedora[opcionIngresada].Precio})\n");
                Console.ResetColor();

                maquinaExpendedora.Remove(opcionIngresada);

                Console.WriteLine("Ingrese 'S' si desea continuar comprando: ");

                respuestaIngresada = Console.ReadLine();
                Console.WriteLine();
            } while ((respuestaIngresada == "s" || respuestaIngresada == "S") && maquinaExpendedora.Count > 0);

            if(maquinaExpendedora.Count == 0)
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
