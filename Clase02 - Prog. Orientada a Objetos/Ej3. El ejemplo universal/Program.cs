using Librería_de_Clases;

namespace Ej3._El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new Estudiante("Gil", "1207", "Miguel");
            Estudiante estudianteDos = new Estudiante("Messina", "3108", "Federico");
            Estudiante estudianteTres = new Estudiante("Menchaca", "0309", "Emmanuel");

            estudianteUno.NotaPrimerParcial = 9;
            estudianteDos.NotaPrimerParcial = 4;
            estudianteTres.NotaPrimerParcial = 7;

            estudianteUno.NotaSegundoParcial = 8;
            estudianteDos.NotaSegundoParcial = 3;
            estudianteTres.NotaSegundoParcial = 6;

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());
        }
    }
}