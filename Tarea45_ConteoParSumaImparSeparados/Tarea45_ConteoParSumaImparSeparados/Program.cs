using System;

namespace Tarea45_ConteoParSumaImparSeparados
{
    /* Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero.
    A partir del primero. Imprimir los números separados. Entre si 7 unidades, contarlos. Cuantos de estos son pares y cuanto vale la suma de los impares.*/
    class Program
    {
        static float num1, num2, sumaImpar;
        static string entrada;
        static int conteoPar, conteo, i;
        static void Main(string[] args)
        {
            //Asignanción de variables
            i = 0;
            num1 = 0;
            num2 = 0;
            sumaImpar = 0;
            conteoPar = 0;
            entrada = "";
            conteo = 0;

            ingresoDeNumerosMayorMenor();
            separarNumerosConteoParSumaImpar();
            Console.ReadKey();
        }

        //Se crea un bucle por si el usuario ingresa el segundo número menor que el primero.
        static private void ingresoDeNumerosMayorMenor()
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

        static private void separarNumerosConteoParSumaImpar()
        {
            while (i <= num2)  //Mientras i sea menor o igual a num2, hacer:
            {
                Console.WriteLine(i);  //Se muestra el valor acumulado de i. 

                if (i % 2 == 0)  //Si el residuo de la división de i entre num2 es igual a 0 Entonces
                {
                    conteoPar = conteoPar + 1;  //Si se cumple la condición se contarán los pares.
                }
                else
                {
                    sumaImpar = sumaImpar + i;  //Si no se cumple la condición se suman los impares.
                }
                conteo = conteo + 1;  //Se cuentan todos los números.
                i = i + 7;  //Iterador, separa entre sí 7 unidades 
            }

            //Impresión de mensajes.
            Console.WriteLine("Hay un total de: " + conteoPar + " números pares");
            Console.WriteLine("La suma de los números impares es de: " + sumaImpar);
            Console.WriteLine("Hay un total de: " + conteo + " números");
        }
    }
}

