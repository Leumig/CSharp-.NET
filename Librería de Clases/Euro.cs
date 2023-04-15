using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador' y 'Cotizador desktop'
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            //cotzRespectoDolar = 0.89;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public static double GetCotizacionStatic()
        {
            return cotzRespectoDolar;
        }

        public void SetCotizacion(double cotizacion)
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

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacionStatic());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)(Dolar)e;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e + (Euro)p;
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.cantidad + e2.cantidad);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e - (Euro)p;
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.cantidad - e2.cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + (Euro)d;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - (Euro)d;
        }
    }
}
