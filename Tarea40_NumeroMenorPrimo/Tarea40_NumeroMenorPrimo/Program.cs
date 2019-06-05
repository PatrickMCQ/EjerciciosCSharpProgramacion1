using System;

namespace Tarea40_NumeroMenorPrimo
{
    class Program
    {
        static int numero, contador;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignanción de variables.
            numero = 0;
            contador = 0;
            entrada = "";

            numeroPrimo();
            Console.ReadKey();
        }

        static private void numeroPrimo()
        {
            //Solicitud de ingreso de datos.
            Console.WriteLine("Ingrese un número para saber si es primo y para saber cual es su menor número primo");
            entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);

            //Bucle para ver cuantos divisores tiene el número.
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)  //Si el residuo de la división entre numero y el valor acumulado de i es 0 Entonces.
                {
                    /*//Se le sumará (+ 1) al valor acumulado de contador. 
                    Para ver cuantas veces se repite el bucle y así encontrar cuantos divisores que tiene el número.*/
                    contador = contador + 1;
                }
            }

            //Bucle para definir si el número tiene dos divisores o no.
            if (contador == 2)  //Si contador tiene un valor acumulado de dos Entonces
            {
                Console.WriteLine(numero + " es un número primo y su menor número primo es 2");  //Es par.
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo y su menor número primo es 2");  //Sino, no es par.
            }
        }
    }
}

