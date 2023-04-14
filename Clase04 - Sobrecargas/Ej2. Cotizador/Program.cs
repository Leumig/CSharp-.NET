using Librería_de_Clases;
using System;

namespace Billete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar cantidadDolar = new Dolar(35);
            Euro cantidadEuro = new Euro(205);
            Pesos cantidadPesos = new Pesos(45);

            Dolar resultadoEnDolar = new Dolar(0);
            Euro resultadoEnEuro = new Euro(0);
            Pesos resultadoEnPesos = new Pesos(0);

            resultadoEnPesos = (Pesos) (cantidadEuro + cantidadDolar);
            Console.WriteLine(resultadoEnPesos.GetCantidad());

            resultadoEnPesos = (Pesos) (cantidadEuro - cantidadDolar);
            Console.WriteLine(resultadoEnPesos.GetCantidad());
        }
    }
}