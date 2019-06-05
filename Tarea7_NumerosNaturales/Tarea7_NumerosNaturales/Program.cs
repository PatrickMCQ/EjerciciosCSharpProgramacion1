using System;

namespace Tarea7_NumerosNaturales
{
    class numerosNat
    {
        static int i;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            i = 1;  //Iterador del bucle while
            entrada = "";  //Variable para entrada de datos.
            numero = 0;  //Variable útil para conversión.

            numerosNaturalesDesde1An();
            Console.ReadKey();
        }

        static private void numerosNaturalesDesde1An()
        {
            Console.WriteLine("Ingrese un número");  //Le pedimos al usuario que ingrese un numero.
            entrada = Console.ReadLine();  //Entrada de datos por usuario.
            numero = Convert.ToSingle(entrada);  //Se hace la conversion de Entrada/Cadena a numero/float.

            while (i <= numero)  //Mientras i sea mayor o igual que numero se realiza lo siguiente.
            {
                Console.WriteLine(i);  //Se muestra en pantalla el valor acumulado de i.
                i = i + 1;  //Se le suma (+1) al valor acumulado de i, para dar todos los números naturales desde 1 hasta condición.
            }
        }
    }
}
