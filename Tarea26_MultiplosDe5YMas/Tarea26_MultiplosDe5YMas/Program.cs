using System;

namespace Tarea26_MultiplosDe5Ymas
{
    class Program
    {
        static int i, suma, sumaMultiplo;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables
            i = 0;
            numero = 0;
            suma = 0;
            sumaMultiplo = 0;
            entrada = "";

            bucleParaMultiplosDe5Suma();
            Console.ReadKey();
        }

        static private void bucleParaMultiplosDe5Suma()
        {
            Console.WriteLine("Ingrese un número para determinar el fin del ciclo: ");  //Solicita al usuario un número para detener el ciclo.
            entrada = Console.ReadLine();  //A entrada se le asigna el número ingresado.
            numero = Convert.ToSingle(entrada);  //Se hace la conversión de string a float, y se le asigna el número tipo float a numero.

            while (i <= numero)  //Mientras i sea menor o igual al número ingresado, hacer:
            {
                if (i % 5 == 0)  //Si el residuo de la division del valor acumulado de i es 0 Entonces
                {
                    sumaMultiplo = sumaMultiplo + i;  //Se le acumula la suma de los multiplos de 5 a sumaMultiplo, si se cumple la condción.
                    i = i + 1;  //Iterardor para continuar con el ciclo.
                }
                else
                {
                    Console.WriteLine(i);  //Muestra en pantalla el valor acumulado de i. 
                    suma = suma + i;  //Se le acumula a suma, la suma de los números, excepto múltiplos de 5, sino se cumple la condición.
                    i = i + 1;  //Iterardor para continuar con el ciclo.
                }
            }

            Console.WriteLine("La suma total de los numeros, excepto los múltiplos de 5, desde cero a" + numero + " es de: " + suma);  //Muestra la suma excepto múltiplos de 5.
            Console.WriteLine("La suma de los múltiplos de 5 desde cero a " + numero + " es de: " + sumaMultiplo);  //Muestra la suma de los múltiplos de 5.
        }
    }
}
