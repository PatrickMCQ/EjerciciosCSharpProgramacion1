using System;

namespace Tarea28_SerieDeNumerosMult5
{
    class Program
    {
        static int i, conteo;
        static float sumaMultiplos5, numeroDeterminado, numMayor, numero;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables.
            i = 1;
            sumaMultiplos5 = 0;
            numeroDeterminado = 0;
            numMayor = 0;
            entrada = "";
            numero = 0;
            conteo = 0;

            serieDeNumerosMultDe5();
            Console.ReadKey();

        }

        static private void serieDeNumerosMultDe5()
        {
            Console.WriteLine("Ingrese el número para determinar el fin de la serie de números");  //Solicita un número.
            entrada = Console.ReadLine(); //A entrada se le asigna el número ingresado.
            numeroDeterminado = Convert.ToSingle(entrada);  //Se convierte de string a float y se lñe asigna el valor de entrada a numDeterminado

            while (i <= numeroDeterminado)  //Mientras i sea menor o igual a numDeterminado, hacer:
            {
                Console.WriteLine("Ingrese un número: ");  //Solicita el ingreso de número.
                entrada = Console.ReadLine();  //A entrada se le asigna el número ingresado.
                numero = Convert.ToSingle(entrada);  //Se convierte de string a float y se lñe asigna el valor de entrada a numero

                if (numero % 5 == 0)  //Si la division de numero entre 5 es igual a 0 Entonces
                {
                    sumaMultiplos5 = sumaMultiplos5 + numero;  //Si se cumple la fucnión, sumará los múltiplos de 5.
                }
                if (numero > numMayor)  //Si numero es mayor a numMayor Entonces
                {
                    numMayor = numero;  //A numMayor se le asigna el valor de numero.
                }
                i = i + 1;  //Iterador, se le suma (+ 1) para continuar con el ciclo según la condición.
                conteo = conteo + 1;  //Se le acumula las veces que el ciclo se repite.

            }

            //Impresión de mensajes.
            Console.WriteLine("La suma de los múltiplos de 5 es de: " + sumaMultiplos5);
            Console.WriteLine("El número mayor es: " + numMayor);
            Console.WriteLine("Usted ingresó un total de: " + conteo + " números");
        }
    }
}

