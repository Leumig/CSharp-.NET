using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador'
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Euro()
        {
            this.cantidad = 0;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)(Dolar) e;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e.GetCantidad() == d.GetCantidad());
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e.GetCantidad() == p.GetCantidad());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.GetCantidad() == e2.GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - d.GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e.GetCantidad() - p.GetCantidad();
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + d.GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.GetCantidad() + p.GetCantidad();
        }
    }
}
