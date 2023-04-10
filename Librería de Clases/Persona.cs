using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona()
        {
            nombre = "NO CARGADO";
            fechaDeNacimiento = DateTime.MinValue;
            dni = 00000000;
        }

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }

        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }

            set
            {
                fechaDeNacimiento = value;
            }

        }
        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }

        }

        static public int CalcularEdad(DateTime fechaIngresada)
        {
            int edad;
            edad = DateTime.Today.AddTicks(-fechaIngresada.Ticks).Year - 1;
            return edad;
        }

        static public string Mostrar(Persona personaIngresada)
        {
            string nombreIngresado = personaIngresada.Nombre;
            DateTime fechaDeNacimientoIngresada = personaIngresada.FechaDeNacimiento;
            int dniIngresado = personaIngresada.Dni;
            int edad = CalcularEdad(personaIngresada.FechaDeNacimiento);

            string texto = "| NOMBRE: " + nombreIngresado + " | FECHA DE NACIMIENTO: " + fechaDeNacimientoIngresada.ToShortDateString() + " | "
                + "DNI: " + dniIngresado + " | EDAD: " + edad + " | " + EsMayorDeEdad(edad) + " |";
            return texto;
        }      

        static public string EsMayorDeEdad(int edadIngresada)
        {
            /*
            string texto = "ES MENOR DE EDAD";
            if(edadIngresada >= 18)
            {
                texto = "ES MAYOR DE EDAD";
            }
            return texto;*/

            if (edadIngresada >= 18)
            {
                return "ES MAYOR DE EDAD";
            }
            else
                return "ES MENOR DE EDAD";
        }



        //Sobrecarga de operadores. Ejemplo con el == y el != 
        public static bool operator == (Persona p1, Persona p2)
        {
            return p1.Dni == p2.Dni;
        }

        public static bool operator != (Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        //Estos operadores sobrecargados == y != solo van a funcionar de esta forma
        //cada vez que querramos comparar dos objetos de tipo Persona.
        //Siempre deben ser public y static.

        public static int operator + (int numero, Persona p1)
        {
            return p1.Dni + numero;
        }
        //En este caso sobrecargo el operador '+'.
        //Sólo va a funcionar esta sobrecarga cuando yo haga:
        //   int + Persona  , es decir, cuando sume un entero
        //más un objeto de tipo Persona. No puede ser al revés ni con otro tipo.

        //Tambien se pueden sobrecargar conversiones.

        /*public static explicit operator int(Persona p)
        {
            return p.Dni;
        }*/

        public static implicit operator int(Persona p)
        {
            return p.Dni;
        }

    }
}
