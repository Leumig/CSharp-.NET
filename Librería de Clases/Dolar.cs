using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador'
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Dolar()
        {
            this.cantidad = 0;
        }

        public Dolar(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Dolar.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return d.GetCantidad() == e.GetCantidad();
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return !(d.GetCantidad() == e.GetCantidad());
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.GetCantidad() == d2.GetCantidad());
        }

        public static Dolar operator - (Dolar d, Euro e)
        {
            return d.GetCantidad() - e.GetCantidad();
        }

        public static Dolar operator - (Dolar d, Pesos p)
        {
            return d.GetCantidad() - p.GetCantidad();
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return d.GetCantidad() + e.GetCantidad();
        }

        public static Dolar operator + (Dolar d, Pesos p)
        {
            return d.GetCantidad() + p.GetCantidad();
        }
    }
}
