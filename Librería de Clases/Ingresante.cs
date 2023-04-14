using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    //Esta clase corresponde al ejercicio 'Registrate'
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            Cursos = cursos;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
            Nombre = nombre;
            Pais = pais;
        }

        public string[] Cursos { get => cursos; set => cursos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            StringBuilder cursos = new StringBuilder();

            datos.AppendLine($"Nombre: {Nombre}");
            datos.AppendLine($"Edad: {Edad}");
            datos.AppendLine($"Género: {Genero}");
            datos.AppendLine($"País: {Pais}");
            datos.AppendLine($"Dirección: {Direccion}");

            foreach (var itemCurso in Cursos)
            {
                if(itemCurso != null)
                {
                    cursos.AppendLine(itemCurso);
                }
            }

            datos.AppendLine($"Curso/s:\n{cursos}");

            return datos.ToString();
        }
    }














}
