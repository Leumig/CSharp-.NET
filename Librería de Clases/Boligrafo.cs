using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor Color 
        { 
            get { return color; } 
        }

        public short Tinta
        {
            get { return tinta; }
        }

        public void SetTinta(short cantidadTinta)
        {
            //Console.WriteLine($"NOS LLEGO {cantidadTinta}");

            short tintaResultante = this.tinta;
            tintaResultante += cantidadTinta;

            if(ValidarCantidadTinta(tintaResultante))
            {
                this.tinta = tintaResultante;
            }
            else
            {
                this.tinta = 0;
            }
        }

        private bool ValidarCantidadTinta(short tinta)
        {
            return tinta >= 0 && tinta <= cantidadTintaMaxima;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            if(gasto <= 0)
            {
                dibujo = "";
                return false;
            }else
            {
                short tintaAUtilizar = this.tinta;

                if (gasto < this.tinta)
                {
                    tintaAUtilizar = gasto;
                }

                //Console.WriteLine($"EL GASTO AHORA MISMO ES {gasto}");
                SetTinta( (short) - gasto );
                //Console.WriteLine($"QUEDO DE TINTA: {Tinta}");

                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"\n[Unidades: {tintaAUtilizar}]");
                while (tintaAUtilizar > 0)
                {
                    sb.Append("" + "*");
                    tintaAUtilizar--;
                }

                dibujo = sb.ToString();
                return true;
            }
        }
    }
}
