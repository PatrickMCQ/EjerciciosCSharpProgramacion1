using System;

namespace Tarea25_MayoroMenorQue10
{
    class Program
    {
        static float numero;
        static int i;
        static string entrada;
        static void Main(string[] args)
        {
            numero = 0;  //variable útil para conversion, se le asignará el número ingresado.
            entrada = "";  //Variable para entrada de datos.
            i = 1;  //Iterador de bucle while.

            serieDeNumerosMayorMenor();
            Console.ReadKey();
        }

        static private void serieDeNumerosMayorMenor()
        {
            while (i <= 5)  //Mientras i sea menor o igual a 5, Hacer:
            {
                Console.WriteLine("Ingrese un número: ");  //Se solicita al usuario que ingrese un número.
                entrada = Console.ReadLine();  //A entrada se le asigna el valor del número ingresado.
                numero = Convert.ToSingle(entrada);  //Se hace la converion del numero ingresado de string a float.

                if (numero > 10)  //Si número es mayor que 10 Entonces
                {
                    Console.WriteLine(numero + " es mayor que 10");  //Si se cumple la condición mostrar en pantalla que el número ingresado es mayor que 10.
                }
                else
                {
                    Console.WriteLine(numero + " es menor que 10");  //Si no se cumple la condción mostrar en pantalla que es menor que 10
                }

                i = i + 1;  //Iterador, sumará (+ 1) para llegar a 5
            }
        }
    }
}

