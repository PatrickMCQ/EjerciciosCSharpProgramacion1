using System;

namespace Tarea52_CuadradosYCubos
{
    class Program
    {
        static int i, cuadrado, cubo;
        static double potencia;
        static void Main(string[] args)
        {
            //Asignación de variables.
            i = 1;
            cuadrado = 0;
            cubo = 0;

            //Método para tener el cuadro y ele cubo de los números del 1 al 10.
            cuadradosCubosDel1al10();

            Console.ReadKey();
        }

        static private void cuadradosCubosDel1al10()
        {
            //Condicional para tener el cuadrado y cubo de los números del 1 al 10.
            while (i <= 10)
            {
                potencia = Math.Pow(i, 2);  //Se le saca potencia a la 2 al valor acumulado de i.
                cuadrado = Convert.ToInt32(potencia);  //El valor de potencia se convierte en int.

                potencia = Math.Pow(i, 3);  //Se le saca potencia  a la 3 al valor acumulado de i.
                cubo = Convert.ToInt32(potencia);  //El valor de potencia se convierte en int.

                Console.WriteLine(i + " ; " + cuadrado + " ; " + cubo);  //Muestra el resultado.
                i = i + 1;  //Se le suma (+ 1) al valor acumulado de i para continuar segú la condición.
            }
        }
    }
}
