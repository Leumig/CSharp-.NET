using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase2
{
    static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            min = -100;
            max = 100;

            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
                return false;
        }


    }
}
