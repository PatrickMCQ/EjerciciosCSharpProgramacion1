using System;

namespace Tarea6_NumerosImparesDesdeEl100HastaLaUnidad
{
    class impares
    {
        static int i, suma;
        static void Main(string[] args)
        {
            i = 99; //Iterador del bucle while, se coloca 99 porque 100 es par.
            suma = 0;  //Esta variable acumulará la suma del valor acumulado de i

            imparesDe100a1andSuma();
            Console.ReadKey();
        }

        static private void imparesDe100a1andSuma()
        {
            while (i >= 1)  //Condició: Mientras i sea mayor o igual a 1 se hará la siguiente acción.
            {
                Console.WriteLine(i);  //Se mostrará en pantalla el valor acumulado de i.
                suma = suma + i;  //Suma acumula el valor de acumulado de i.
                i = i - 2;  //Mientras se vaya iterando se irá restando (- 2) al valor acumulado de i.
            }

            Console.WriteLine("La suma total de los números impares de 100 a la unidad es de: " + suma);  //Se mostrará en pantalla la suma total de los impares.
        }
    }
}

