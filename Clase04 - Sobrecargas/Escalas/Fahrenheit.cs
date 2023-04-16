using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalas
{
    public class Fahrenheit
    {
        private double temperatura;

        public double Temperatura { get => temperatura; set => temperatura = value; }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius c = new Celsius();
            c.Temperatura = (f.Temperatura - 32) * 5 / 9;

            return c;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = new Kelvin();
            k.Temperatura = ((f.Temperatura - 32) / 1.8) + 273.15;

            return k;
        }
    }
}
