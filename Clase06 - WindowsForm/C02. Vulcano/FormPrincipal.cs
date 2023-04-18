using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escalas;

namespace C02._Vulcano
{   
    /*Consigna
    Partir del ejercicio Fahrenheit 451 y agregarle un proyecto de tipo Windows Forms App.*/
    public partial class FormPrincipal : Form
    {
        private Celsius temperaturaCelsius = new Celsius();
        private Fahrenheit temperaturaFahrenheit = new Fahrenheit();
        private Kelvin temperaturaKelvin = new Kelvin();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Celsius)temperaturaFahrenheit;
            var resultadoDos = (Kelvin)temperaturaFahrenheit;

            txt_FahrAFahr.Text = temperaturaFahrenheit.Temperatura.ToString("0.000");
            txt_FahrACels.Text = resultadoUno.Temperatura.ToString("0.000");
            txt_FahrAKel.Text = resultadoDos.Temperatura.ToString("0.000");
        }

        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Fahrenheit)temperaturaCelsius;
            var resultadoDos = (Kelvin)temperaturaCelsius;

            txt_CelsAFahr.Text = resultadoUno.Temperatura.ToString("0.000");
            txt_CelsACels.Text = temperaturaCelsius.Temperatura.ToString("0.000");
            txt_CelsAKel.Text = resultadoDos.Temperatura.ToString("0.000");
        }

        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            var resultadoUno = (Fahrenheit)temperaturaKelvin;
            var resultadoDos = (Celsius)temperaturaKelvin;

            txt_KelAFahr.Text = resultadoUno.Temperatura.ToString("0.000");
            txt_KelACels.Text = resultadoDos.Temperatura.ToString("0.000");
            txt_KelAKel.Text = temperaturaKelvin.Temperatura.ToString("0.000");
        }

        private void txt_TempFahrenheit_TextChanged(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_TempFahrenheit.Text, out double temperatura);
            if(resultado)
            {
                temperaturaFahrenheit.Temperatura = temperatura;
            }
        }

        private void txt_TempCelsius_TextChanged(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_TempCelsius.Text, out double temperatura);
            if(resultado)
            {
                temperaturaCelsius.Temperatura = temperatura;
            }
        }

        private void txt_TempKelvin_TextChanged(object sender, EventArgs e)
        {
            bool resultado = double.TryParse(txt_TempKelvin.Text, out double temperatura);
            if (resultado)
            {
                temperaturaKelvin.Temperatura = temperatura;
            }
        }
    }
}
