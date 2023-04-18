using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Validador
    {
        static bool TryValidarDni(int dni)
        {
            //

            return true;
        }

        static public int ValidarDniOrThrow(int dni)
        {
            if (dni < 0)
            {
                throw new ArgumentException();
            }

            return dni;
        }






    }
}
