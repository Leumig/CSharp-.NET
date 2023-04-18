using System.Net;
using System.Text;

namespace Biblioteca_de_clases
{
    abstract public class Persona
    {
        //Hicimos que esta clase sea abstracta.
        //Esto hace que esta clase no pueda instanciarse, es decir: no podemos crear 
        //un objeto en base a esta clase.
        //En este caso nos sirve hacer esto ya que no vamos a crear un objeto de tipo Persona.
        //Simplemente tenemos esta clase Persona para que sea heredada por otras clases hijas.

        private string nombre;
        private string apellido;
        private int dni;
        protected string apodo; //Un atributo con visibilidad 'protected' solo se acceder a él
                                //en esta misma clase, y en sus clases derivadas.

        public Persona(int dni)
        {
            Dni = dni;
        }

        public Persona(string nombre, string apellido, int dni) :this(dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; }
            private set
            {
                dni = Validador.ValidarDniOrThrow(value);
            } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"DNI: {Dni}");

            return sb.ToString();
        }

        /*public virtual string Saludar() //Con el 'virtual' estoy indicando que este método va a poder
                                          //ser sobreescripto por una clase heredada (hija).
        {
            return "Hola soy " + Nombre;
        }*/

        public abstract string Saludar(); //Método abstracto. NO puede tener cuerpo. Es sólo una firma
                                          //y está para que las clases derivadas de Persona puedan sobreescribirlo.



    }

}