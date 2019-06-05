using System;

namespace Tarea25_ExceptoLosMultiplosDe2
{
    class Program
    {
        static string entrada;
        static int numero, i;
        static void Main(string[] args)
        {
            entrada = "";  //Variable para entrada de datos
            numero = 0;  //Variable útil para conversión, se le asignará el valor de entrada de string a int.
            i = 0;  //Iterador del bucle

            ingresoDeNumeros1al100();
            Console.ReadKey();
        }

        static private void ingresoDeNumeros1al100()
        {
            Console.WriteLine("Ingrese un número: ");  //Se solicita al usuario el ingreso de un número.
            entrada = Console.ReadLine();  //A entrada se le asigna el valor del número ingresado.
            numero = Convert.ToInt32(entrada);  //Se hace la conversión de string a int y se le asigna a numero el valor de entrada.

            i = numero;  //Se le asigna el valor de numero a i.

            if (i % 2 == 1)  //Si el residuo de la division de i entre 2 es igual a 1 Entonces
            {
                while (i <= 100)  //Mientras i sea menor o igual a 100, hacer:
                {
                    if (i % 2 == 1)  //Si el residuo de la divisón de i entre 2 es igual a 1 Entonces
                    {
                        Console.WriteLine(i);  //Se muestra en pantalla el valor acumulado de i, si se cumple la condición.
                        i = i + 1;  //Iterador, se le suma (+ 1) para completar la condición si see cumple. 
                    }
                    else
                    {
                        i = i + 1;  //Iterador, se le suma (+ 1) para completar la condición si no se cumple.
                    }
                }
            }
            else
            {
                Console.WriteLine("Error!!! Usted ingresó un múltiplo de 2");  //Se muestra error en pantalla por ser múltiplo de 2
            }
        }
    }
}
3