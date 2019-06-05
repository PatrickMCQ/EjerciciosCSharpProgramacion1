using System;

namespace Tarea21_MultiplosDe2Y3
{
    class Program21
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 1;  //Iterador del bucle while.
            conteo = 0;  //Acumulará las veces que se repita el ciclo.

            multiploDe2Y3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2Y3ConteoImpresion()
        {
            while (i <= 100)  //Mientras i sea menor o igual que 100, hacer:
            {
                if ((i % 2 == 0) && (i % 3 == 0))  //Si el residuo de la division de i entre 2 es igual a cero "Y" el residuo de la division de i entre 2 es igual a cero
                {
                    Console.WriteLine(i);  //Mostrará en pantalla el valor acumulado de i.
                    conteo = conteo + 1;  //Acumula las veces que se repite el ciclo sumando 1.
                }

                i = i + 1;  //Itareador, se suma (+ 1) al valor acumulado de i.
            }

            Console.WriteLine("Hay un total de " + conteo + " múltiplos de 2 y de 3, desde uno hasta cien");  //Muestra en pantalla el conteo tal de múltiplos de 2 o de 3.
        }
    }
}
