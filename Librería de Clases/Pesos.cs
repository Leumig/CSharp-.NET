using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador' y 'Cotizador desktop'
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
            //cotzRespectoDolar = 0.023;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Pesos.GetCotizacionStatic());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)(Dolar)p;
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p + (Pesos)d;
        }

        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.cantidad + p2.cantidad);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p - (Pesos)d;
        }

        public static Pesos operator -(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.cantidad - p2.cantidad);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + (Pesos)e;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p - (Pesos)e;
        }
    }

}
