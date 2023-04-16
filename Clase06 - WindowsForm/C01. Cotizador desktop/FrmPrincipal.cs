using Billete;
using Librería_de_Clases;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace C01._Cotizador_desktop
{
    public partial class FrmPrincipal : Form
    {
        private Dolar valorDolar = new Dolar(0);
        private Euro valorEuro = new Euro(0);
        private Pesos valorPesos = new Pesos(0);

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Candado_Click(object sender, EventArgs e)
        {
            CambiarEstadoCandado();
        }

        private void CambiarEstadoCandado()
        {
            if(!(txt_CotizEuro.Enabled && txt_CotizPeso.Enabled))
            {
                txt_CotizEuro.Enabled = true;
                txt_CotizPeso.Enabled = true;
                //btn_Candado.Text = "ABIERTO";
                btn_Candado.BackgroundImage = global::C01._Cotizador_desktop.Properties.Resources.desbloquear;
            }
            else
            {
                txt_CotizEuro.Enabled = false;
                txt_CotizPeso.Enabled = false;
                //btn_Candado.Text = "CERRADO";
                btn_Candado.BackgroundImage = global::C01._Cotizador_desktop.Properties.Resources.cerrar;
            }
        }

        private void txt_Euro_Leave(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_Euro.Text, out double cantidad);

            if(resultado)
            {
                valorEuro.SetCantidad(cantidad);
            }         
        }

        private void txt_Dolar_Leave(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_Dolar.Text, out double cantidad);
            valorDolar.SetCantidad(cantidad);        
        }

        private void txt_Peso_Leave(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_Peso.Text, out double cantidad);
            valorPesos.SetCantidad(cantidad);

        }

        private void btn_Euro_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Euro)valorDolar;
            var resultadoDos = (Euro)valorPesos;

            txt_EuroAEuro.Text = valorEuro.GetCantidad().ToString();
            txt_EuroADolar.Text = resultadoUno.GetCantidad().ToString();
            txt_EuroAPeso.Text = resultadoDos.GetCantidad().ToString();
        }

        private void btn_Dolar_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Dolar)valorEuro;
            var resultadoDos = (Dolar)valorPesos;

            txt_DolarAEuro.Text = resultadoUno.GetCantidad().ToString();
            txt_DolarADolar.Text = valorDolar.GetCantidad().ToString();
            txt_DolarAPeso.Text = resultadoDos.GetCantidad().ToString();
        }

        private void btn_Peso_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Pesos)valorEuro;
            var resultadoDos = (Pesos)valorDolar;

            txt_PesoAEuro.Text = resultadoUno.GetCantidad().ToString();
            txt_PesoADolar.Text = resultadoDos.GetCantidad().ToString();
            txt_PesoAPeso.Text = valorPesos.GetCantidad().ToString();
        }

        private void txt_CotizEuro_Leave(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_CotizEuro.Text, out double cantidad);
            valorEuro.SetCotizacion(cantidad);
        }

        private void txt_CotizPeso_Leave(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_CotizPeso.Text, out double cantidad);
            valorPesos.SetCotizacion(cantidad);     
        }
    }
}