using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Alumno : Persona //Estoy llamando a la clase Persona (clase base/madre)
    {
        private int legajo;

        public int Legajo { get => legajo; set => legajo = value; }

        //En la herencia, estoy obligado a llamar a algún constructor base (de la clase madre)
        //Se hereda todo lo que no sea privado, excepto los constructores.
        public Alumno(string nombre, string apellido, int dni, int legajo) : base(nombre, apellido, dni)
        {
            Legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{base.ToString()}"); //Cuando uso 'base.' me estoy refiriendo a la clase base (Persona)
                                             //Si usara 'this.' me estoy refiriendo a esta misma clase (Alumno)
            sb.AppendLine($"Legajo: {Legajo}");

            return sb.ToString();
        }

        /*public override string Saludar() //Sobreescribo un método virtual de la clase base
        {
            return $"Hola, estoy sobreescribiendo Saludar. Legajo: {Legajo}";
        }*/

        public override string Saludar() //Sobreescribo un método abstract de la clase base. 
                                         //Estoy OBLIGADO a sobreescribir TODOS los métodos abstractos de la clase base.
                                         //De lo contrario, no compila.
        {
            return $"Hola, estoy sobreescribiendo un método abstract 'Saludar'. Legajo: {Legajo}";
        }





    }
}
