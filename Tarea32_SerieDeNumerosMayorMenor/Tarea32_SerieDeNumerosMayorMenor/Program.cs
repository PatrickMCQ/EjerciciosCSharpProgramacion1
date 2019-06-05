using System;

namespace Tarea32_SerieDeNumerosMayorMenor
{
    class Program
    {
        static string entrada;
        static float num1, num2, suma;
        static int i, conteo;
        static void Main(string[] args)
        {
            //Asignanción de variables
            entrada = "";
            i = 0;
            num1 = 0;
            num2 = 0;
            conteo = 0;
            suma = 0;

            ingresoDeNumeros();
            multiplosDe2();
            Console.ReadKey();
        }

        static private void ingresoDeNumeros()
        {
            Console.WriteLine("Ingrese un número: ");  //Se solicita un número.
            entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
            num1 = Convert.ToSingle(entrada);  //Se hace la conversión de string a float, se le asigna el valor de entrada a num1
            i = Convert.ToInt32(num1);  //Iterador, el valor de num1 se le asigna a i

            Console.WriteLine("Ingrese un número mayor que: " + num1);  //Se solicita un número.
            entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
            num2 = Convert.ToSingle(entrada);  //Se hace la conversión de string a float, se le asigna el valor de entrada a num2

            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor que " + num1);   //Se solicita un número.
                entrada = Console.ReadLine();  // Se le asigna el número a entrada.
                num2 = Convert.ToSingle(entrada);  //Se hace la conversión de string a float, se le asigna el valor de entrada a num2
            }
        }

        static private void multiplosDe2()
        {
            while (i <= num2)  //Mientras i sea menor o igual que 100, hacer:
            {
                if (i % 2 == 0)  //Si el residuo de la division de i entre 2 es igual a cero Entonces
                {
                    Console.WriteLine(i);  //Mostrará en pantalla el valor acumulado de i.
                    suma = suma + i;  //Acumulará la suma de los múltiplos de 2.
                    conteo = conteo + 1;  //Acumula las veces que se repite el ciclo sumando 1.
                }

                i = i + 1;  //Itareador, se suma (+ 1) al valor acumulado de i.
            }

            //Mensaje de pantalla
            Console.WriteLine("Hay un total de " + conteo + " múltiplos de 2");
            Console.WriteLine("La suma de los múltiplos de 2 es de: " + suma);
        }
    }
}

