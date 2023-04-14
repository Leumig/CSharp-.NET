using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    //Esta clase corresponde al ejercicio 'Cotizador'
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad / (Pesos.GetCotizacion() / Euro.GetCotizacion()));
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p.GetCantidad() == d.GetCantidad());
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p.GetCantidad() == e.GetCantidad());
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1.GetCantidad() == p2.GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.GetCantidad() - d.GetCantidad();
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.GetCantidad() - e.GetCantidad();
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.GetCantidad() + d.GetCantidad();
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.GetCantidad() + e.GetCantidad();
        }
    }
}
