using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class FormularioPersona : Form
    {
        private Persona personaIngresada;
        
        public Persona Persona
        {
            get { return personaIngresada; }
        }

        public FormularioPersona()
        {
            InitializeComponent();
            //Este método es el que carga todos los componentes visuales del
            //formulario. Es decir, cuando se ejecuta, me abre el formulario
            //y muestra todo su contenido (botones, labels, etc).
        }

        private void CerrarFormulario()
        {
            DialogResult = DialogResult.Cancel;

            //DialogResult es el estado actual del formulario
            //En esa línea nosotros le cambiamos el estado
            //Se lo cambiamos usando el enumerado DialogResult,
            //y elegimos el valor Cancel. 
        }
        private void CerrarFormulario(DialogResult resultado)
        {
            DialogResult = resultado;
            //Le cambiamos el estado al valor que recibe por parametro.
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            personaIngresada = new Persona();
            //Instancio el objeto Persona

            bool nombreValido = false;
            bool legajoValido = false;
            //Lo uso para validar (CLARAMENTE ESTO NO DEBE HACERSE ACA)

            if(txb_Nombre.Text.Length > 1 && txb_Nombre.Text.Length < 20)
            {
                personaIngresada.Nombre = txb_Nombre.Text;
                nombreValido = true;
            }
            else
            {
                MessageBox.Show("Nombre no valido");
            }

            if (int.TryParse(txb_Legajo.Text, out int legajoIngresado) == false || legajoIngresado < 0)
            {
                MessageBox.Show($"Legajo no valido, el legajo ingresado fue: {legajoIngresado}");
            }else
            {
                personaIngresada.Legajo = legajoIngresado;
                legajoValido = true;
            }
            
            if(nombreValido && legajoValido)
            {
                //DialogResult = DialogResult.OK; //En vez de hacer esto, uso la funcion creada
                CerrarFormulario(DialogResult.OK);
                //Le cambie el estado al DialogResult, por lo tanto, se cierra el formulario
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
            //Le cambie el estado al DialogResult, por lo tanto, se cierra el formulario
        }
    }
}
