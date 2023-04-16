using Escalas;

namespace A01._Fahrenheit_451
{
    internal class Program
    {
        /*Ejercicio A01 - Fahrenheit 451
        Consigna
        Crear un proyecto de consola y un proyecto de biblioteca de clases.
        Agregar al último tres clases Fahrenheit, Celsius y Kelvin.
        Realizar la implementación necesaria para poder convertir una temperatura
        en sus distintas unidades de medida (Fahrenheit, Celsius y Kelvin).*/
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius();
            Fahrenheit fahrenheit = new Fahrenheit();
            Kelvin kelvin = new Kelvin();

            celsius.Temperatura = 15;
            fahrenheit.Temperatura = 15;
            kelvin.Temperatura = 15;

            var resultado1 = (Fahrenheit)celsius;
            var resultado2 = (Kelvin)celsius;
            Console.WriteLine($"Los 15 grados Celsius, en Fahrenheit serían: {resultado1.Temperatura} grados.");
            Console.WriteLine($"Los 25 grados Celsius, en Kelvin serían: {resultado2.Temperatura} grados.\n");

            var resultado3 = (Celsius)fahrenheit;
            var resultado4 = (Kelvin)fahrenheit;
            Console.WriteLine($"Los 15 grados Fahrenheit, en Celsius serían: {resultado3.Temperatura} grados.");
            Console.WriteLine($"Los 15 grados Fahrenheit, en Kelvin serían: {resultado4.Temperatura} grados.\n");

            var resultado5 = (Celsius)kelvin;
            var resultado6 = (Fahrenheit)kelvin;
            Console.WriteLine($"Los 15 grados Kelvin, en Celsius serían: {resultado5.Temperatura} grados.");
            Console.WriteLine($"Los 15 grados Kelvin, en Fahrenheit serían: {resultado6.Temperatura} grados.");
        }
    }
}