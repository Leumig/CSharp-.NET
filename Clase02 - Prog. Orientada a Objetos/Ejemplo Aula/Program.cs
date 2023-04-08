using System;

namespace Ejemplo_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("German");

            Profesor profesor1 = new Profesor("Curcio");
            Profesor profesor2 = new Profesor("Ferrete");

            //aula1.AgregarAlumno(alumno1);

            Materia laboratorioII = new Materia("Laboratorio II");
            Materia programacionII = new Materia("Programación II");
            Materia matematicaI = new Materia("Matematica I");

            Alumno[] listaAlumnos2D = new Alumno[3]
            {
                alumno1,
                new Alumno("Juan"),
                new Alumno("Miguel")
            };

            Aula aula1 = new Aula("2D", laboratorioII, profesor1, 20);
            Aula aula2 = new Aula("7G", programacionII, profesor1, 35);
            //Aca creé 2 aulas con el constructor que pide la capacidad.
            //Por lo tanto, estas aulas están creadas y tienen una capacidad de
            //20 y 35 respectivamente, pero no están ocupadas por ningún alumno.
            //Esto es así ya que su atributo listaAlumnos está en [20] y [35] pero
            //cada lugarcito de esos arrays, están vacíos.

            Alumno[] listaAlumnos1E = new Alumno[3];
            listaAlumnos1E[0] = new Alumno("Jorge");
            listaAlumnos1E[1] = new Alumno("Camila");
            listaAlumnos1E[2] = new Alumno("Raul");

            Aula aula3 = new Aula("1E", matematicaI, profesor2, listaAlumnos1E);
            //Aca creé un aula3, pero usando un constructor distinto al anterior.
            //Este constructor no recibe una cantidad específica, sino que es más directo,
            //recibe directamente la lista de alumnos, en este caso una lista de 3 alumnos,
            //Jorge, Camila y Raul. 
        }
    }
}
