using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalas
{
    public class Celsius
    {
        private double temperatura;

        public double Temperatura { get => temperatura; set => temperatura = value; }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = new Fahrenheit();
            f.Temperatura = (c.Temperatura * 1.8) + 32;

            return f;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin k = new Kelvin();
            k.Temperatura = c.Temperatura + 273.15;

            return k;
        }
    }
}
