using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public static class Calculadora
    {
        //Esta clase corresponde al ejercicio 'Calculadora'
        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            int resultadoOperacion;
            switch (operacionMatematica)
            {
                case "+":
                    resultadoOperacion = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultadoOperacion = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultadoOperacion = primerOperando * segundoOperando;
                    break;
                default:
                    try
                    {
                        resultadoOperacion = primerOperando / segundoOperando;
                    }
                    catch(DivideByZeroException)
                    {
                        throw;
                    }
                    break;
            }
            return resultadoOperacion;
        }

        public static int CalcularFactorial(int numeroIngresado)
        {
            int resultadoFactorial = numeroIngresado;
            int iteraciones = numeroIngresado;

            for (int restador = 1; iteraciones > 1; restador++)
            {
                resultadoFactorial = resultadoFactorial * (numeroIngresado - restador);
                iteraciones--;
            }
            return resultadoFactorial;
        }
    }
}
