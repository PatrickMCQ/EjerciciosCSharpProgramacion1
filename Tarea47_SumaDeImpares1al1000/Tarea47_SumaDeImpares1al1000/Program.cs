using System;

namespace Tarea47_SumaDeImpares1al1000
{
    class Program
    {
        static int i, sumaImpar;
        static void Main(string[] args)
        {
            //Asignanción de variables.
            i = 1;
            sumaImpar = 0;

            sumaImparDel1Al1000();
            Console.ReadKey();
        }

        static private void sumaImparDel1Al1000()
        {
            //Bucle para imprimir los números del 1 al 100
            while (i <= 1000)
            {
                Console.WriteLine(i);  //Mostrará el valor acumulado de i

                //Verificación de números impares..
                if (i % 2 == 1)  //Si el residuo de la división de i entre 2 es igual a 1 Entonces
                {
                    sumaImpar = sumaImpar + i;  //Suma los impares
                }

                i = i + 1;  //Se le suma (+ 1) al valor acumulado de i para imprimir los números del 1 al 1000 hasta la condición.
            }

            //Mensaje en pantalla: Total de suma Impar.
            Console.WriteLine("La suma total de los números impares del 1 al 100 es de: " + sumaImpar);
        }
    }
}
