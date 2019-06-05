using System;

namespace Tarea43_NumNaturalesConteoParSumaImpar
{
    class Program
    {
        static int num1, num2, conteo, conteoPar, sumaImpar;
        static string entrada;
        static void Main(string[] args)
        {
            num1 = 0;  //Variable que se le asignará el valor de entrada de string a int.
            num2 = 0;  //Variable que se le asignará el valor de entrada de string a int.
            conteo = 0;  //Variable que acumulará las veces que se repita el bucle.
            conteoPar = 0;  //Variable que acumulará las veces que se repita el bucle, si se cumple la condición.
            sumaImpar = 0;  //Variable que sumará el valor acumulado de sumaImpar más los números generados por el bucle, si se cumple la condición.
            entrada = "";  //Variable para entrada de datos.

            ingresoDeDatos();
            conteoSumaImparYConteoPar();
            Console.ReadKey();
        }

        static private void ingresoDeDatos()
        {
            Console.WriteLine("Ingrese el primer número: ");  //Solicitará al usuario que ingrese el primer número.
            entrada = Console.ReadLine();  //El dato ingresado se le asignará a entrada.
            num1 = Convert.ToInt32(entrada);  //A num1 se le asignará el valor de entrada de String a int.

            Console.WriteLine("Ingrese el segundo número: ");  //Solicitará al usuario que ingrese el segundo número.
            entrada = Console.ReadLine();  //El dato ingresado se le asignará a entrada.
            num2 = Convert.ToInt32(entrada);  //A num2 se le asignará el valor de entrada de String a int.
        }

        static private void conteoSumaImparYConteoPar()
        {
            if (num1 < num2)  //Si num1 es menor que num2 Entonces
            {
                while (num1 <= num2)  //Mientras num1 sea menor o igual a num2, Hacer:
                {
                    Console.WriteLine(num1);  //Mostrará en pantalla el valor acumulado de num1.
                    if (num1 % 2 == 0)  //Si el residuo de la división de num1 entre dos es igual a 0 Entonces
                    {
                        conteoPar = conteoPar + 1;  //Si se cumple la condición entonces conteoPar llevará la cuenta de las veces que se repite el ciclo.
                    }
                    else
                    {
                        sumaImpar = sumaImpar + num1;  //Si no se cumple la condición entonces sumaImpar acumulurá la suma de los valores generados por el ciclo.
                    }

                    conteo = conteo + 1;  //Acumulará las veces que se repita el bucle principal.
                    num1 = num1 + 1;  //num1 actúa como Iterador, sumando (+ 1) para mostrar los números naturales hasta que no cumpla la condición.
                }
            }
            else
            {
                while (num2 <= num1)  //Mientras num2 sea menor o igual a num1, Hacer:
                {
                    Console.WriteLine(num2);   //Mostrará en pantalla el valor acumulado de num2.
                    if (num2 % 2 == 0)  //Si el residuo de la división de num2 entre dos es igual a 0 Entonces
                    {
                        conteoPar = conteoPar + 1;  //Si se cumple la condición entonces conteoPar llevará la cuenta de las veces que se repite el ciclo.
                    }
                    else
                    {
                        sumaImpar = sumaImpar + num1;  //Si no se cumple la condición entonces sumaImpar acumulurá la suma de los valores generados por el ciclo.
                    }

                    conteo = conteo + 1;  //Acumulará las veces que se repita el bucle principal.
                    num2 = num2 + 1;  //num2 actúa como Iterador, sumando (+ 1) para mostrar los números naturales hasta que no cumpla la condición.
                }

            }

            Console.WriteLine("Hay un total de: " + conteo + " números naturales");  //Muestra pantalla el conteo total de los números naturales.
            Console.WriteLine("Hay un total de: " + conteoPar + " números pares");  //Muestra el conteo de los números Pares.
            Console.WriteLine("La suma de los números impares es de: " + sumaImpar);  //Muestra la suma total de Impares
        }
    }
}
