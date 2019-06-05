using System;

namespace Tarea46_MultiplosDe2ConteoSuma
{
    class Program
    {
        static int i, conteoM, sumaM, num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignanción de variables.
            i = 0;
            conteoM = 0;
            sumaM = 0;
            num1 = 0;
            num2 = 0;
            entrada = "";

            ingresoDeNumerosYBucleNegativos();
            numeroMayoroMenor();
            bucleParaImpresionDeMultiplos2();
            Console.ReadKey();
        }

        static private void ingresoDeNumerosYBucleNegativos()
        {
            //Ingreso de datos.
            Console.WriteLine("Ingrese el primer número entero positivo: ");  //Se solicita un número.
            entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
            num1 = Convert.ToInt32(entrada);  //Se hace la conversión de string a int, se le asigna el valor de entrada a num1
            i = num1;  //Iterador, el valor de num1 se le asigna a i

            Console.WriteLine("Ingrese un número entero positivo mayor que: " + num1);  //Se solicita un número.
            entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
            num2 = Convert.ToInt32(entrada);  //Se hace la conversión de string a int, se le asigna el valor de entrada a num2

            //Verificación si los números son negativo.
            while ((num1 < 0) || (num2 < 0))
            {
                Console.WriteLine("Usted ingresó números negativos");  //Mensaje de números negativos.
                Console.WriteLine("Ingrese el primer número entero positvo: ");  //Se solicita un número.
                entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
                num1 = Convert.ToInt32(entrada);  //Se hace la conversión de string a int, se le asigna el valor de entrada a num1
                i = num1;  //Iterador, el valor de num1 se le asigna a i

                Console.WriteLine("Ingrese un número entero positivo mayor que: " + num1);  //Se solicita un número.
                entrada = Console.ReadLine();  //Se le asigna el  número a entrada.
                num2 = Convert.ToInt32(entrada);  //Se hace la conversión de string a int, se le asigna el valor de entrada a num2
            }


        }

        static private void numeroMayoroMenor()
        {
            //Verificación si el segundo número es mayor o igual al primer número.
            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor que " + num1);   //Se solicita un número.
                entrada = Console.ReadLine();  // Se le asigna el número a entrada.
                num2 = Convert.ToInt32(entrada);  //Se hace la conversión de string a int, se le asigna el valor de entrada a num2
            }
        }

        static private void bucleParaImpresionDeMultiplos2()
        {
            //Impresión, suma y conteo de múltiplos de 2.
            while (i <= num2)  //Mientras i sea menor o igual que num2, hacer:
            {
                if (i % 2 == 0)  //Si el residuo de la división entre el valor acumulado de i y 2 es igual a 0 Entonces.
                {
                    Console.WriteLine(i);  //Muestra el valor acumulado de i.
                    sumaM = sumaM + i;  //Suma los múltiplos de 2.
                    conteoM = conteoM + 1;  //Cuenta los múltiplos de 2.
                    i = i + 2;  //Acumula para imprimir múltiplos de 2 hasta la condición.
                }
                else
                {
                    num1 = num1 + 1;  //Sino, a num1 se le suma (+ 1), por si es 23 se le suma 1 para dar 24 y ser múltiplo de 2.
                    i = num1;  //Se le asigna a i el valr de num1.  i fucniona como iterador.
                    Console.WriteLine(i);  //Muestra el valor acumulado de i.
                    sumaM = sumaM + i;  //Suma el múltiplo de 2.
                    conteoM = conteoM + 1;  //Cuenta el múltiplo de 2.
                    i = i + 2;  //Acumula para imprimir múltiplos de 2 hatsa la considición

                }
            }

            //Mensajes en pantalla, suma y conteo.
            Console.WriteLine("Hay un total de: " + conteoM + " múltiplos de 2");
            Console.WriteLine("La suma total de los múltiplos de 2 es de: " + sumaM);
        }

    }
}

