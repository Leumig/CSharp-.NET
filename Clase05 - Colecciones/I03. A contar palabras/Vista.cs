using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I03._A_contar_palabras
{
    /*Consigna
    Crear un proyecto de tipo Windows Forms App, con un RichTextBox y un botón Calcular.*/
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            char[] separaciones = new char[] {' ', '\n', '-'};
            //Creo un array con los caracteres que representan un espacio entre dos cadenas

            string[] arrayPalabrasSeparadas = rtb_Mensaje.Text.Split(separaciones, StringSplitOptions.RemoveEmptyEntries);
            //Creo un array de strings y le doy el valor del texto ingresado, el cual va a ser
            //un array de strings dividido por las separaciones del array de separaciones
            //'Split' recorre el string dividiendolo según las separaciones que le pasemos, y devuelve un array

            foreach (var itemArray in arrayPalabrasSeparadas)
            {
                if(diccionario.ContainsKey(itemArray))
                {
                    diccionario[itemArray]++;
                    //Esto funciona porque 'itemArray es un string', entonces vamos al elemento del
                    //diccionario que tenga ese valor como Key. Y le hacemos ++ (modificando su Value).
                }
                else
                {
                    diccionario.Add(itemArray, 1);
                }
            }
            
            var diccionarioOrdenado = diccionario.OrderByDescending(x => x.Value);
            //Creo un nuevo diccionario ordenado descendentemente según el Value

            StringBuilder sb = new StringBuilder();
            int indice = 1;

            foreach (var itemDicciconario in diccionarioOrdenado.Take(3))
            {
                sb.AppendLine($"{indice}. {itemDicciconario.Key} [{itemDicciconario.Value}]");
                indice++;
            }

            MessageBox.Show($"TOP 3 PALABRAS MÁS REPETIDAS\n{sb}", "Resultado");
        }

        private void btn_Enunciar_Click(object sender, EventArgs e)
        {
            char[] separaciones = new char[] { ' ', '\n', '-', ',' };
            string[] arrayPalabrasSeparadas = rtb_Mensaje.Text.Split(separaciones, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LISTA DE PALABRAS\n");
            
            foreach (var itemPalabra in arrayPalabrasSeparadas)
            {
                sb.AppendLine($"- {itemPalabra}");
            }

            MessageBox.Show(sb.ToString(), "Enunciado");
        }
    }
}
