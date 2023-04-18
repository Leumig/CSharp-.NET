using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    //Esta clase corresponde a los ejercicios de la Maquina Expendedora
    public class Producto
    {
        private string nombre;
        private int precio;
        private int codigo;
        private static int codigoActual;

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = codigoActual;
            codigoActual++;
        }

        static Producto()
        {
            codigoActual = 1000;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        } 
        public int Codigo
        {
            get
            {
                return codigo;
            }
        }
    }
}
