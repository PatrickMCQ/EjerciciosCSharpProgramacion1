using System;

namespace Tarea14_SumaDeCuadrados
{
    class Program14
    {
        static int i, suma, potencia;
        static double numeros;
        static void Main(string[] args)
        {
            i = 0;  //Iterador del bucle while

            numerosParesdel0al100Cuadrados();
            Console.ReadKey();
        }

        static private void numerosParesdel0al100Cuadrados()
        {
            while (i <= 100)  //Mientras i sea menor que 100, hacer:
            {
                numeros = Math.Pow(i, 2);  //La variable numeros acumularáel cuadrado del valor de i, se utiliza el metodo pow para potencia.
                potencia = Convert.ToInt32(numeros);  //Se convierte el valor de numeros de double a int y se le asigna el valor acumulado a potencia.
                suma = suma + potencia;  //Se suma el valor acumulado en suma  más el valor acumulado en potencia.
                i = i + 2;  //Me va iterando sumanod (+ 2) para darme números pares.
            }

            Console.WriteLine("La suma de los cuadrados de los números pares del comprendidos entre 0 y 100 es de: " + suma);  /*Muestra en pantalla la sumna de los
                                                                                                                              numeros pares de 0 a 10 */

        }
    }
}

