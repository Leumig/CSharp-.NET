namespace EjerciciosClase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numeroIngresado;

            while(i < 10)
            {
                Console.WriteLine("Ingrese un numero entero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if(Validador.Validar(numeroIngresado, -100, 100))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Ese numero no está dentro del rango");
                }
            }
        }

        static class Validador
        {
            public static bool Validar(int valor, int min, int max)
            {
                if (valor >= min && valor <= max)
                {
                    return true;
                }
                else
                    return false;
            }
        }




    }
}