using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escalas
{
    public class Kelvin
    {
        private double temperatura;

        public double Temperatura { get => temperatura; set => temperatura = value; }

        public static explicit operator Celsius(Kelvin k)
        {
            Celsius c = new Celsius();
            c.Temperatura = k.Temperatura - 273.15;

            return c;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = new Fahrenheit();
            f.Temperatura = 1.8 * (k.Temperatura - 273.15) + 32;

            return f;
        }
    }
}
