using System;
using Librería_de_Clases;

namespace Ej4._Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoUno = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoDos = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine($"|| Cantidades de tinta || Azul:{boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            boligrafoUno.Recargar(); //Los recargo a su punto máximo (variable const)
            boligrafoDos.Recargar(); //Los recargo a su punto máximo (variable const)
            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            boligrafoUno.SetTinta(0); //Le agrego 0 de tinta (no pasará nada)
            boligrafoDos.SetTinta(-10); //Le quito 10 de tinta
            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            boligrafoUno.SetTinta(-200); //Le quito 200 de tinta (va a quedar en 0)
            boligrafoDos.SetTinta(-90); //Le quito 90 de tinta (va a quedar en 0)
            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            boligrafoUno.SetTinta(30); //Le agrego 30
            boligrafoDos.SetTinta(20); //Le agrego 20
            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            string dibujo;

            if(boligrafoUno.Pintar(50, out dibujo)) // Pinto sólo 30 unidades (y queda en 0)
            {                                       // Si pongo 0 o menos, no entra al if
                Console.ForegroundColor = boligrafoUno.Color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }

            if (boligrafoDos.Pintar(10, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.Color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }

            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            if (boligrafoUno.Pintar(10, out dibujo)) 
            {                                       
                Console.ForegroundColor = boligrafoUno.Color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }

            if (boligrafoDos.Pintar(10, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.Color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }

            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            boligrafoUno.SetTinta(30); //Le agrego 30
            boligrafoDos.SetTinta(20); //Le agrego 20
            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");

            if (boligrafoDos.Pintar(80, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.Color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }

            Console.WriteLine($"|| Cantidades de tinta || Azul: {boligrafoUno.Tinta}  Rojo: {boligrafoDos.Tinta}");
            Console.WriteLine("===================================================== \n");
        }
    }
}