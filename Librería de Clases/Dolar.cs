using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador' y 'Cotizador desktop'
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public void SetCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad / Pesos.GetCotizacionStatic());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacionStatic());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d + (Dolar)p;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + (Dolar)e;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d - (Dolar)p;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - (Dolar)e;
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad + d2.cantidad);
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad - d2.cantidad);
        }
    }
}
