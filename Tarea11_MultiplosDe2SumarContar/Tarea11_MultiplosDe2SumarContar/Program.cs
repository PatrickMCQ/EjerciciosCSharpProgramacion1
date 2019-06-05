using System;

namespace Tarea11_MultiplosDe2SumarContar
{
    class Tarea11
    {
        static int i, conteo, suma;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            i = 2;  //Iterador del bucle while.
            conteo = 0;  //Almacenará las veces que el ciclo while se repita.
            suma = 0;  //Acumulará la suma del valor acumulado en I.
            numero = 0;  //Variable útil para conversion de cadena a float.
            entrada = "";  //Variable de entrada de datos.

            conteoSumaMultiplos2();
            Console.ReadKey();
        }

        static private void conteoSumaMultiplos2()
        {
            Console.WriteLine("Ingrese un número: ");  //Se le solicita al usuario que ingrese un número.
            entrada = Console.ReadLine();  //Entarad almacenará el dato.

            numero = Convert.ToSingle(entrada);  //numero recibirá el valor convertido a float de cadena.

            while (i <= numero)  //Mientras i sea menor o igual a numero, se realizará lo siguiente:
            {
                Console.WriteLine(i);  //Mostrará en pantalla el valor acumulado de i.
                suma = suma + i;  //Acumulará el valor acumulado de i sumandolo.
                i = i + 2;  //Se sumará (+ 2) al valor acumulado de i, para generar múltpiplos de 2
                conteo = conteo + 1;  //Amacenará las veces que el ciclo while se repita, sumando (+ 1) cada vez que se repita el ciclo.
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltplos de 2");  //Mostrará en pantalla el total de multiplos de 2 que existen.
            Console.WriteLine("La suma total de los " + conteo + " múltiplos de es es de: " + suma);  //Mostrará en pantalla la suma de los múltiplos de 2.
        }
    }
}
