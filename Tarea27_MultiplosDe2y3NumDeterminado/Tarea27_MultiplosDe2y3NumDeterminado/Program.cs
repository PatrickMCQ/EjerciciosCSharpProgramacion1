using System;

namespace Tarea27_MultiplosDe2y3NumDeterminado
{
    class Program
    {
        static int i, conteo;
        static string entrada;
        static float numero;
        static void Main(string[] args)
        {
            //Asignación de variables
            i = 1;  //Iterador del bucle while.
            conteo = 0;  //Acumulará las veces que se repita el ciclo.
            entrada = "";
            numero = 0;

            multiploDe2Y3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2Y3ConteoImpresion()
        {
            Console.WriteLine("Ingrese para determinar el fin del ciclo, para imprimir los múltiplos de 2 y 3 hasta el número que usted ingrese");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);

            while (i <= numero)  //Mientras i sea menor o igual que 100, hacer:
            {
                if ((i % 2 == 0) && (i % 3 == 0))  //Si el residuo de la division de i entre 2 es igual a cero "Y" el residuo de la division de i entre 2 es igual a cero
                {
                    Console.WriteLine(i);  //Mostrará en pantalla el valor acumulado de i.
                    conteo = conteo + 1;  //Acumula las veces que se repite el ciclo sumando 1.
                }

                i = i + 1;  //Itareador, se suma (+ 1) al valor acumulado de i.
            }

            Console.WriteLine("Hay un total de " + conteo + "múltiplos de 2 y tres, desde la unidad hasta " + numero);  //Muestra en pantalla el conteo tal de múltiplos de 2 y de 3.
        }
    }
}

