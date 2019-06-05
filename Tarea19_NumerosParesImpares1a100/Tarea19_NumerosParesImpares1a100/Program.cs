using System;

namespace Tarea19_NumerosParesImpares1a100
{
    class Program19
    {
        static int i, sumaPar, sumaImpar;
        static void Main(string[] args)
        {
            i = 1;  //Itearador del bucle while.
            sumaPar = 0;  //Variable que acumulará el valor de la suma de los númerso pares.
            sumaImpar = 0;  //Variable que acumulará el valor de la suma de los númerso impares.

            numerosDel1al100ParImpar();
            Console.ReadKey();
        }

        static private void numerosDel1al100ParImpar()
        {
            while (i <= 100)  //Mientras i sea menor que 100, hacer:
            {
                Console.WriteLine(i);  //Muestra en pantalla el valor acumulado de i.

                if (i % 2 == 0)  //Si el residuo de la divisón del valor acumulado entre 2 es igual a 0 Entonces.
                {
                    sumaPar = sumaPar + i;  //Se suma al valor acumulado mas i.
                }
                else
                {
                    sumaImpar = sumaImpar + i;  //Se acumula al valor acumulado más i.

                }
                i = i + 1;  //Iterador, se suma (+ 1) al valor acumulado hasta que determine la condición.
            }

            Console.WriteLine("La suma de los números pares de 1 a 100 es de: " + sumaPar);  //Muestra en pantalla la suma total delos pares de 1 a 100.
            Console.WriteLine("La suma de los números impares de 1 a 100 es de: " + sumaImpar);  ////Muestra en pantalla la suma total delos impares de 1 a 100.
        }
    }
}
