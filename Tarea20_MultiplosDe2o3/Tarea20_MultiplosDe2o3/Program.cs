using System;

namespace Tarea20_MultiplosDe2o3
{
    class Program20
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 1;  //Iterador del bucle while.
            conteo = 0;  //Acumulará las veces que se repita el ciclo.

            multiploDe2o3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2o3ConteoImpresion()
        {
            while (i <= 100)  //Mientras i sea menor o igual que 100, hacer:
            {
                if ((i % 2 == 0) || (i % 3 == 0))  //Si el residuo de la division de i entre 2 es igual a cero "o" el residuo de la division de i entre 2 es igual a cero
                {
                    Console.WriteLine(i);  //Mostrará en pantalla el valor acumulado de i.
                    conteo = conteo + 1;  //Acumula las veces que se repite el ciclo sumando 1.
                }

                i = i + 1;  //Itareador, se suma (+ 1) al valor acumulado de i.
            }

            Console.WriteLine("Hay un total de múltiplos de: " + conteo);  //Muestra en pantalla el conteo tal de múltiplos de 2 o de 3.
        }
    }
}
