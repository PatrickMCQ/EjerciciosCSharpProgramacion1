using System;

namespace Tarea50_AreayDiametroCircunferencia
{
    class Program
    {
        static float radio, p;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables.
            radio = 0;
            p = 3.1416f;
            entrada = "";

            //Ingreso de radio.
            Console.WriteLine("Ingrese el radio de la circunferencia: ");
            entrada = Console.ReadLine();
            radio = Convert.ToSingle(entrada);

            //Diámetro.
            Console.WriteLine("El diámetro es de: " + (radio / p));

            //Área.
            Console.WriteLine("El área es de: " + (p * (radio * radio)));

            //Circunferencia.
            Console.WriteLine("La circunferencia es de: " + ((2 * p) * radio));

            Console.ReadKey();
        }
    }
}
