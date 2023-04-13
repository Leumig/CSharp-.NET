using PrimerFormulario;

namespace PrimerFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HOLA");
            //lbl_Titulo.Text = "Texto cambiado desde click";

            lbl_Titulo.Text = "Hola, " + txb_Nombre.Text;

            //var nombre = txb_Nombre.Text;
            //lbl_Titulo.Text = nombre;
            //Otra forma de hacerlo (con la var)
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioPersona formularioPersona = new FormularioPersona();
            //Instancio al formulario Persona

            //DialogResult es el estado actual del formulario
            //Es a la vez, un enumerado. OK es uno de sus valores


            //Cuando el codigo llega al 'ShowDialog()', se queda ahí, y no sale de ahí
            //hasta que cambie su estado (su DialogResult)
            if (formularioPersona.ShowDialog() == DialogResult.OK)                
            {
                //Si el estado es OK, recibo Persona
                string datosPersona = formularioPersona.Persona.ToString();
                //Uso la propiedad Persona que cree en la clase Persona, y uso
                //el metodo ToString, el cual sobreescribí.

                MessageBox.Show(datosPersona, "DATOS RECIBIDOS");
                //El segundo parámetro del MessageBox.Show es el título del cartel

                MessageBox.Show("Estado OK, se hizo la carga");
            }
            else
            {
                MessageBox.Show("Estado CANCEL, no se hizo la carga");
            }

        }
    }
}