using System;

namespace Tarea51_MultiploDeNumeros
{
    class Program
    {
        static int num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            //Aisgnación de variables.
            num1 = 0;
            num2 = 0;
            entrada = "";

            //Ingreso de datos.
            Console.WriteLine("Ingrese el primer número: ");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número: ");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);

            //Método para saber si el primer número es múltiplo del segundo número.
            multiploDelPrimero();
            Console.ReadKey();
        }

        static private void multiploDelPrimero()
        {
            //Condicional para saber si el primer número es múltiplo del segundo.
            if (num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " es múltiplo de " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " no es múltiplo de " + num2);
            }
        }
    }
}
