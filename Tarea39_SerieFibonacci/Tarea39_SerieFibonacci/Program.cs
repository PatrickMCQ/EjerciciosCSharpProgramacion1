using System;

namespace Tarea39_SerieFibonacci
{
    class Program
    {
        static int pre, pos, val;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            //Asgnaciónd de varibales.
            val = 0;
            pre = 0;
            pos = 1;
            numero = 0;
            entrada = "";

            condicionalParaGeerarSerieFibonacci();
            Console.ReadKey();
        }

        static private void condicionalParaGeerarSerieFibonacci()
        {
            //Se solicita una cantidad para generar los términos de la serie fibonacci
            Console.WriteLine("Ingrese la cantidad de términos que quiere generar: ");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);

            //Se muestra en pantalla el valor de pre y pos.
            Console.WriteLine(pre + "  " + pos);

            //Bucle para generar la serie fibonacci según la cantidad ingresda.
            for (int i = 3; i <= numero; i++)  //i = Iterardor.
            {
                val = pre + pos;  //A val se le asignará la suma entre pre y pos.
                pre = pos;  //A pre se le asigna el valor acumulado de pos.
                pos = val;  //A pos se le asigna el valor acumulado de val.

                Console.WriteLine(val);  //Se muestra en pantalla el valor acumulado de val.
            }
        }

    }
}
