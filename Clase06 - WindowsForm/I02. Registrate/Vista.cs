using Librería_de_Clases;

namespace I02._Registrate
{
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            string nombreIngresado = txt_Nombre.Text;
            string direccionIngresada = txt_Direccion.Text;
            int edadIngresada = (int) num_Edad.Value;
            string paisIngresado = lst_Pais.Text;
            string generoIngresado;
            string[] cursosIngresados = new string[3];

            if(rad_Masculino.Checked)
            {
                generoIngresado = rad_Masculino.Text;
            }else if(rad_Femenino.Checked)
            {
                generoIngresado = rad_Femenino.Text;
            }else
            {
                generoIngresado = rad_NoBinario.Text;
            }

            if(chk_PrimerCurso.Checked)
            {
                cursosIngresados[0] = chk_PrimerCurso.Text;
            }

            if(chk_SegundoCurso.Checked)
            {
                cursosIngresados[1] = chk_SegundoCurso.Text;
            }

            if(chk_TercerCurso.Checked)
            {
                cursosIngresados[2] = chk_TercerCurso.Text;
            }

            Ingresante ingresanteIngresado = new Ingresante(nombreIngresado, direccionIngresada, generoIngresado,
                                                            paisIngresado, cursosIngresados, edadIngresada);

            MessageBox.Show(ingresanteIngresado.Mostrar(), "DATOS");
        }
    }
}