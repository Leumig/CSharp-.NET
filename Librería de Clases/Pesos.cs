using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Pesos()
        {
            this.cantidad = 0;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        static Pesos()
        {
            cotzRespectoDolar = 102.65;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

    }
}
