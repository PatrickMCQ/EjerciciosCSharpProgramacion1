using System;

namespace Tarea48_OperacionesEnteras
{
    class Program
    {
        static int num1, num2, suma, producto, diferencia, cociente, resto;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables.
            num1 = 0;
            num2 = 0;
            suma = 0;
            producto = 0;
            diferencia = 0;
            cociente = 0;
            resto = 0;
            entrada = "";

            //Ingreso de datos.
            Console.WriteLine("Ingrese el primer número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);

            //Métodos.
            sumaDeNumeros();
            productoDeNumeros();
            diferenciaDeNumeros();
            cocienteDeNumeros();
            restoDeNumeros();
            Console.ReadKey();
        }

        static private void sumaDeNumeros()
        {
            suma = num1 + num2;
            Console.WriteLine("La suma es de: " + suma);
        }

        static private void productoDeNumeros()
        {
            producto = num1 * num2;
            Console.WriteLine("El producto es de: " + producto);
        }

        static private void diferenciaDeNumeros()
        {
            diferencia = num1 - num2;
            Console.WriteLine("La diferencia es de: " + diferencia);
        }

        static private void cocienteDeNumeros()
        {
            cociente = num1 / num2;
            Console.WriteLine("El cociente es de: " + cociente);
        }

        static private void restoDeNumeros()
        {
            resto = num1 % num2;
            Console.WriteLine("El resto es de: " + resto);
        }
    }
}
