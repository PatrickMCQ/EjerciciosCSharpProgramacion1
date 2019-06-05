using System;

namespace Tarea34_sumasSucesivas
{
    class Program
    {
        static int i, contador;
        static float num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables
            i = 0;
            contador = 1;
            num1 = 0;
            num2 = 0;
            entrada = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");  //Se solicita el rpimer número.
            entrada = Console.ReadLine();  //Se le asigna a entradad el dato ingresado.
            num1 = Convert.ToSingle(entrada);  //Se hace la conversión de string a float y se le asigna el valor de entrada a num1

            Console.WriteLine("Ingrese el segundo número: ");  //Se solicita el rpimer número.
            entrada = Console.ReadLine();  //Se le asigna a entradad el dato ingresado.
            num2 = Convert.ToSingle(entrada);  //Se hace la conversión de string a float y se le asigna el valor de entrada a num1

            //Condicional para las sumas sucesivas
            if ((num1 >= 0) && (num2 >= 0))  //Si num1 es mayor o igual a 0 y num2 es mayor o igual a 0 Entonces 
            {
                while (contador <= num1)  //Mientras contador sea menor o igual a num1, hacer:
                {
                    contador = contador + 1;  //A contador se le suma (+ 1) hasta que lo diga la condición
                    i = i + Convert.ToInt32(num2);  ////Suma sucesiva, para obtener el producto.
                }

                Console.WriteLine("El producto de los dos números mediante sumas suceivas es de: " + i);  //Muestra el producto mendiante sumas sucesivas.
            }
            else
            {
                Console.WriteLine("NO PUEDE CONTINUAR!!! Usted ha escrito un número negativo");  //No se puede realizar con números negativos.

            }
        }
    }
}
