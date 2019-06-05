using System;

namespace Tarea13_ConteoSumaTeclado500
{
    class Program13
    {
        static int conteo;
        static float i, suma, numero;
        static string entrada;
        static void Main(string[] args)
        {
            i = 0;  //Iterador del bucle while del método  sumaConteo8PosicionesHasta500()
            conteo = 0;  //Acumulará las veces que se repita el bucle del método  sumaConteo8PosicionesHasta500()
            suma = 0;  //Acumulará la suma según el bucle del método  sumaConteo8PosicionesHasta500()
            numero = 0;  //Variable útil para la conversión de cadena a float, en el método numeroIngresadoMenorQue500()
            entrada = "";  //Variable para entrada de datos, en el método numeroIngresadoMenorQue500()

            numeroIngresadoMenorQue500();
            sumaConteo8PosicionesHasta500();
            Console.ReadKey();
        }

        static private void numeroIngresadoMenorQue500()
        {
            Console.WriteLine("Ingrese un número menor que 500: ");  //Se solicitará al usuario que ingrese un número menor que 500.
            entrada = Console.ReadLine();  //A entrada se le asignará el dato solicitado.

            numero = Convert.ToSingle(entrada);  //Se convierte el dato acumulado en entrada de cadena a float.

            while (numero > 500)  //Mientras numero sea mayor a 500, hacer:
            {
                Console.WriteLine("El número ingresado es mayor que 500, ingrese un número menor que 500: ");  /*Se mostraá en pantalla que el número es mayor a 500
                                                                                                                y se solicitará uno juevo menor que 500 */
                entrada = Console.ReadLine(); //A entrada se le asignará el dato solicitado.
                numero = Convert.ToSingle(entrada);  //Se convierte el dato acumulado en entrada de cadena a float.

            }
        }

        static private void sumaConteo8PosicionesHasta500()
        {
            i = numero;  //A i se le asigna el valor de la variable numero.
            while (i < 500)  //Mientras i sea menor que 500, hacer:
            {
                Console.WriteLine(i);  //Se mostrará en pantalla el valor acumulado de i.
                suma = suma + i;  //Se suma el valor acumulado de suma más el valor acumulado de i.
                i = i + 8;  //Al valor acumulado de i se le suma (+ 8) para separar los números en 8 posiciones.
                conteo = conteo + 1;  //Se acumulan las veces que se repite el ciclo.
            }

            Console.WriteLine("Hay un total de: " + conteo + " numeros desde " + numero + " hasta 500 separados en 8 posiciones");  //Muestra en pantalla el conteo.
            Console.WriteLine("La suma total es de: " + suma);  //Muestra en pantall las suma total.
        }
    }
}

