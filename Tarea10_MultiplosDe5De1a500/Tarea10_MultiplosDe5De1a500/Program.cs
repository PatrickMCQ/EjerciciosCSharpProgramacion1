using System;

namespace Tarea10_MultiplosDe5De1a500
{
    class Tarea10
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 5;  //Iterador del bucle while, se coloca 5 porque 0 no es múltiplo de 5.
            conteo = 0;  //Variable que almmacenará la veces que el bucle se repita.

            multiplosDe5();
            Console.ReadKey();
        }

        static private void multiplosDe5()
        {
            while (i <= 500)  //Mientras i sea menor a 500 se realizará la siguiente acción::
            {
                Console.WriteLine(i);  //Se muestra en pantalla el valor acumulado de i.
                i = i + 5;  //Se le suman (+ 5) al valor acumulado de i para hacer múltiplos de 5.
                conteo = conteo + 1;  //Conteo acumula las veces que el ciclo se repite.
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltiplos de 5 de 0 a 500");  //Se muestra en pantalla cuantos múltiplos de 5 hay del 0 a 500.
        }
    }
}
