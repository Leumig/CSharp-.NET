using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Cuenta
    {
        public string titulo;
        public float cantidad;
        public Cuenta(string titulo, float cantidad)
        {
            this.titulo = titulo;
            this.cantidad = cantidad;
        }

        public string Titulo { get => titulo; }
        public float Cantidad { get => cantidad; }


        public void Mostrar(Cuenta cuentaIngresada)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=====================================================");
            sb.AppendLine($"El título de la cuenta es: {cuentaIngresada.Titulo}");
            sb.AppendLine($"El monto actual de la cuenta es: {cuentaIngresada.Cantidad}");
            //Con los StringBuilder no se puede escribir haciendo uso de {0} {1} {2}, etc...
            sb.AppendLine("=====================================================");

            Console.WriteLine(sb);
        }

        public void Ingresar(Cuenta cuentaIngresada, float montoIngresado)
        {
            if (montoIngresado > 0)
            {
                cantidad += montoIngresado;
            }
        }

        public void Retirar(Cuenta cuentaIngresada, float montoIngresado)
        {
            cantidad -= montoIngresado;
        }

    }
}
