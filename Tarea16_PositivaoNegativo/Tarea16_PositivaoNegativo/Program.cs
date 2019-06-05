using System;

namespace Tarea16_PositivoNegativo
{
    class Program16
    {
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            numero = 0;  //Variable útil para conversión.
            entrada = "";  //Variable para entrada de datos.

            numeroPositivoNegativo();
            Console.ReadKey();
        }

        static private void numeroPositivoNegativo()
        {
            Console.WriteLine("Ingrese un número para saber si es positivo o negativo: ");  //Se solicita al usuario el ingreso de datos.
            entrada = Console.ReadLine();  //Se le asigna al entrada el dato recibido.
            numero = Convert.ToSingle(entrada);  //Se hace la conversión de string a float, y se le asigna el valor de entrada tipo float.

            if (numero > 0)  //Si numero es mayor a 0 Entonces:
            {
                Console.WriteLine("El número ingresado es positivo: ");  //Se muestra al usuario que si número es positivo si se cumple la condición.
            }
            else
            {
                Console.WriteLine("El número ingresado es negativo: ");  //Se muestra en pantalla que el numero es negativo, si no se cumple la función.
            }
        }
    }
}
