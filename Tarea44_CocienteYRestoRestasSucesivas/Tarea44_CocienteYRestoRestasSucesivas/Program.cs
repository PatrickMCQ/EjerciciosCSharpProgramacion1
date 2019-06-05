using System;

namespace Tarea44_CocienteYRestoRestasSucesivas
{
    class Program
    {
        static int cociente, resto;
        static float dividendo, divisor;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignación de variables
            cociente = 0;
            resto = 0;
            dividendo = 0;
            divisor = 0;
            entrada = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");  //Se solicita el rpimer número.
            entrada = Console.ReadLine();  //Se le asigna a entradad el dato ingresado.
            dividendo = Convert.ToSingle(entrada);  //Se hace la conversión de string a float y se le asigna el valor de entrada a dividendo.

            Console.WriteLine("Ingrese el segundo número: ");  //Se solicita el rpimer número.
            entrada = Console.ReadLine();  //Se le asigna a entradad el dato ingresado.
            divisor = Convert.ToSingle(entrada);  //Se hace la conversión de string a float y se le asigna el valor de entrada a divisor.

            //Condicional para las restas sucesivas
            if ((dividendo >= 0) && (divisor >= 0))  //Si dividendo es mayor o igual a 0 y divisor es mayor o igual a 0 Entonces 
            {
                resto = Convert.ToInt32(dividendo);
                while (resto >= divisor)  //Mientras contador sea menor o igual a num1, hacer:
                {
                    resto = resto - Convert.ToInt32(divisor);  ////resta sucesiva para obtener el resto.
                    cociente = cociente + 1;  //Se suma (+ 1) hasta que se detenga el ciclo.

                }

                Console.WriteLine("El cociente es de: " + cociente);  //Muestra el cociente.
                Console.WriteLine("El resto es de: " + resto);  //Muestra el resto.
            }
            else
            {
                Console.WriteLine("NO PUEDE CONTINUAR!!! Usted ha escrito un número negativo");  //No se puede realizar con números negativos.

            }
        }
    }
}
