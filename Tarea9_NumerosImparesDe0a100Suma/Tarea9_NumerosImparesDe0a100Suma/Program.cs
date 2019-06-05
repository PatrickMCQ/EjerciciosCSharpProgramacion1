using System;

namespace Tarea9_NumerosImparesDe0a100Suma
{
    class Tarea9
    {
        static int i, suma;
        static void Main(string[] args)
        {
            i = 1;  /*Iterardor del bucle while, no se coloca 0 ya que cero es la ausencia de los números y no se estima como impar o par
                    muchos argumentan que el cero puede llegar a ser par, pero no se está definido aún*/
            suma = 0;  //Esta variable acumulará el valor acumulado de i.

            sumaDeImparesDe0a100();
            Console.ReadKey();
        }

        static private void sumaDeImparesDe0a100()
        {
            while (i <= 100)  //Mientras i sea menor o igual a 100 se realiza la siguiente acción.
            {
                suma = suma + i;  //Suma del valor acumulado de i al valor acumuladado de suma.
                i = i + 2;  //Se suma (+ 2) al valor acumulado de i. Se coloca 2 para llegar a ser impares.
            }

            Console.WriteLine("La suma de los impares comprendidos entre 0 y 100 es de: " + suma);  //Se muestra en pantalla la suma de los impares.
        }
    }
}
