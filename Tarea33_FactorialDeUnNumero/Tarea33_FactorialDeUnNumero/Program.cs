using System;

namespace Tarea33_FactorialDeUnNumero
{
    class Program
    {
        static float numero, factor;
        static int i;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignanción de variables
            i = 1;
            numero = 0;
            entrada = "";
            factor = 1;

            bucleParaFactorial();
            Console.ReadKey();
        }

        static private void bucleParaFactorial()
        {
            Console.WriteLine("Ingrese un número para obtener su factorial: ");  //Se solicita un numero.
            entrada = Console.ReadLine();  //Se le asinga a entrada el dato ingresado.
            numero = Convert.ToSingle(entrada);  //Se hace la conversión de string a float.Se le asigna el valor de entrada a numero.

            //bucle para encontrar la factorial del número
            while (i <= numero)  //Mientras i sea menor o igual a numero, hacer:
            {
                factor = factor * i;  //Se multiplica el valor acumulado de factor por el valor acumulado de i
                i = i + 1;  //Iterador, se suma (+ 1) hasta que sea según la condición.
            }

            //Número negativos no tienen factorial
            if (numero >= 0)  //Si numero es mayor o igual a 0 Entonces (Cero tiene factorial y es 1)
            {
                Console.WriteLine("La factorial del número es de: " + factor);  //Muestra la factorial del número.
            }
            else
            {
                Console.WriteLine("Los números negativos no tienne factorial");  //Los negativos no tienen factorial.
            }
        }



    }
}

