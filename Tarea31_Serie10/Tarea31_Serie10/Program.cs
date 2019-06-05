using System;

namespace Tarea31_Serie10
{
    class Program
    {
        static int i, serie10;
        static void Main(string[] args)
        {
            //Asignanción de variables.
            i = 0;
            serie10 = 0;

            //Bucle while.
            while (serie10 <= 10)  //Mientras serie10 sea menor o igual a 100, hacer:
            {
                i = 1;  //iterador de bucle.
                while (i <= 10)  //Mientras i sea menor o igual a 10, hacer:
                {
                    Console.WriteLine(i);  //Se mostrará el valor acumulado de 1
                    i = i + 1;  //iterador, para impresión de número.
                }
                serie10 = serie10 + 1;  //iterador, que sumará (+ 1) hasta que sea según la condición
            }

            Console.ReadKey();
        }
    }
}
