using System;
using Librería_de_Clases;

namespace Ej1._Necesito_un_prestamo
{
    /*Ejercicio I01 - Creo que necesito un préstamo
    Consigna
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaUno = new Cuenta("Miguel", 50000);
            Cuenta cuentaDos = new Cuenta("Fede", 8000.500f);
            Cuenta cuentaTres = new Cuenta("Emma", 1425.250f);

            cuentaUno.Mostrar(cuentaUno);
            cuentaDos.Mostrar(cuentaDos);
            cuentaTres.Mostrar(cuentaTres);

            cuentaUno.Ingresar(cuentaUno, 10000);
            cuentaDos.Ingresar(cuentaDos, 10000);
            cuentaTres.Ingresar(cuentaTres, 10000);

            Console.WriteLine("=====================================================");
            Console.WriteLine("Se realizaron ingresos en las cuentas");
            Console.WriteLine("=====================================================");

            cuentaUno.Mostrar(cuentaUno);
            cuentaDos.Mostrar(cuentaDos);
            cuentaTres.Mostrar(cuentaTres);

            cuentaUno.Retirar(cuentaUno, 50000);
            cuentaDos.Retirar(cuentaDos, 20000);
            cuentaTres.Retirar(cuentaTres, 11400);

            Console.WriteLine("=====================================================");
            Console.WriteLine("Se realizaron retiros en las cuentas");
            Console.WriteLine("=====================================================");

            cuentaUno.Mostrar(cuentaUno);
            cuentaDos.Mostrar(cuentaDos);
            cuentaTres.Mostrar(cuentaTres);
        }
    }
}