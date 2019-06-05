using System;

namespace Tarea49_MediaAritmetica
{
    class Program
    {
        static int num1, num2, num3;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables.
            num1 = 0;
            num2 = 0;
            num3 = 0;
            entrada = "";

            //Ingreso de datos por usuario.
            Console.WriteLine("Ingrese el primer número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            num3 = Convert.ToInt32(entrada);

            //Método para comparar los tres números.
            comparacionDeNumeros();

            //Suma de los tres números.
            Console.WriteLine("La suma de los números es de: " + (num1 + num2 + num3));

            //Media aritmética de los tres números.
            Console.WriteLine("La media aritmética de los números es de: " + ((num1 + num2 + num3) / 3));

            Console.ReadKey();
        }

        static private void comparacionDeNumeros()
        {
            //Condicional para ver que número es el mayor de los tres
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El número mayor es " + num1);
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El número mayor es " + num2);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + num3);

                }
            }

            //Condicional para ver que número es el menor de los tres.
            if ((num1 < num2) && (num1 < num3))
            {
                Console.WriteLine("El número menor es " + num1);
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine("El número menor es " + num2);
                }
                else
                {
                    Console.WriteLine("El número menor es " + num3);

                }
            }
        }

    }
}
