using System;

namespace Tarea8_MultiplosDe3
{
    class Tarea8
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 3;  //Iterador del bucle while.
            conteo = 0;  //Esta variable me contará cuantos multiplos de 3 hay.

            multiplosDe3De1a100();
            Console.ReadKey();
        }

        static private void multiplosDe3De1a100()
        {
            while (i <= 100)  //Mientres i se menor o igual a 100 se realizará lo siguiente.
            {
                Console.WriteLine(i);  //Se muestra en pantalla el valor acumulado de i.
                i = i + 3;  //Se suma (+ 3) al valor acumulado de i.
                conteo = conteo + 1;  //Cuenta cuantas veces se repite el ciclo.
            }

            Console.WriteLine("Existe un total de: " + conteo + " múltiplos de 3");  //Se muestra en pantalla cuantos múltiplos de 3 hay.
        }
    }
}
