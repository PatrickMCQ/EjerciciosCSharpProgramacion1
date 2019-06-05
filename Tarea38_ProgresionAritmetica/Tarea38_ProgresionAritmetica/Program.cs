using System;

namespace Tarea38_ProgresionAritmetica
{
    class Program
    {
        static float numInicial, numFinal, diferencia;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignanción de variables
            numInicial = 0;
            numFinal = 0;
            diferencia = 0;
            entrada = "";

            //Se solicita el ingreso de datos
            Console.WriteLine("Ingrese el número con que se va a iniciar: ");
            entrada = Console.ReadLine();
            numInicial = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese el número con que se va a finalizar: ");
            entrada = Console.ReadLine();
            numFinal = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese la diferencia: ");
            entrada = Console.ReadLine();
            diferencia = Convert.ToSingle(entrada);

            //Métodos
            bucleWhileParaProgresionAritmetica();
            identificadorDeNumerosNegativos();
            Console.ReadKey();
        }

        static private void identificadorDeNumerosNegativos()
        {
            //Bucle para identificar si numInicial O numFinal son negativos, si es más de alguno de los dos, se solicita el ingreso nuevamnete de los números positivos.
            while ((numInicial < 0) || (numFinal < 0))
            {
                Console.WriteLine("Ingrese nuevamente el número con que se va a iniciar, Positivo ");
                entrada = Console.ReadLine();
                numInicial = Convert.ToSingle(entrada);

                Console.WriteLine("Ingrese nuevamente el número con que se va a finalizar, positivo: ");
                entrada = Console.ReadLine();
                numFinal = Convert.ToSingle(entrada);
            }

            //Bucle para identificar si diferencia es negativo, si lo es, se solicita el ingreso nuevamnete del número positivo..
            while (diferencia < 0)
            {
                Console.WriteLine("Ingrese la diferencia: ");
                entrada = Console.ReadLine();
                diferencia = Convert.ToSingle(entrada);

            }
        }

        static private void bucleWhileParaProgresionAritmetica()
        {
            //Bucle para hacer la progresión Aritmética.
            while (numInicial <= numFinal) //Mientras numInicial sea menor o igual que numFinal, hacer:
            {
                Console.WriteLine(numInicial);  //Muestra en pantalla el valor acumulado de numInicial.

                numInicial = numInicial + diferencia;  //numInicial va acumulando la suma de su valor acumulado más diferencia.
            }
        }
    }
}

