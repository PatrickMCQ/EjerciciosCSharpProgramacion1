using System;

namespace Tarea37_DigitosDeUnNumero
{
    class Program
    {
       
        static int numEntero, contador;
        static string entrada;
        static double numTruncado;
        static void Main(string[] args)
        {
            numEntero = 0;
            contador = -1;
            entrada = "";
            numTruncado = 0;


            identificacionDePositivosYNegativos();
            contarDigitosDeNumero();
            Console.ReadKey();
        }

        static private void identificacionDePositivosYNegativos()
        {
            Console.WriteLine("Ingrese un número entero positivo: ");
            entrada = Console.ReadLine();
            numEntero = Convert.ToInt32(entrada);

            while (numEntero < 0)
            {
                Console.WriteLine("ERROR!!! Usted ingresó un número negativo, ingrese un número nuevamente entero positivo: ");
                entrada = Console.ReadLine();
                numEntero = Convert.ToInt32(entrada);
            }
        }

        static private void contarDigitosDeNumero()
        {
            numTruncado = Convert.ToSingle(numEntero);

            while (numTruncado != 0)
            {
                numTruncado = (Math.Truncate(numTruncado) / 10);
                contador = contador + 1;
            }

            Console.WriteLine("El número ingresado tiene " + contador + " cifras");
        }
    }
}

