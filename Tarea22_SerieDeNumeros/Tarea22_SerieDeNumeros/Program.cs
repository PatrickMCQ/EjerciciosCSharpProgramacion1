using System;

namespace Tarea22_SerieDeNumeros
{
    class Program
    {
        static string entrada;
        static float numero, numMayor, numMenor;
        static int i;
        static void Main(string[] args)
        {
            i = 1;  //Iterador del bucle while.
            numero = 0;  //Variable útil para conversión de string a int.
            numMayor = 0;  //Variable que almacenará al numero Mayor.
            numMenor = 9999;  //Variable que almacenará al número Menor.
            entrada = "";  //Vaiable para entrada de datos.


            numeroMayorMenorEnSerieDeNumero();
            Console.ReadKey();
        }

        static private void numeroMayorMenorEnSerieDeNumero()
        {
            while (i <= 5)  //Mientras i sea menor o igual a 5, hacer:
            {
                Console.WriteLine("Ingrese un número: ");  //Se solicita el ingreso de datos.
                entrada = Console.ReadLine();  //Se almacena en entrada el valor del dato ingresado.
                numero = Convert.ToSingle(entrada);  //Se hace la conversión de string a int del valor del dato ingresado y se le aigna el valor a numero.



                if (numero > numMayor)  //Si numero es mayor a numMayor Entonces
                {
                    numMayor = numero;  //Si el número ingresado es mayor al valor acumuludao de numMayor entonces se le asignará el valor de num a numMayor, de lo contrario no.
                }

                if (numero < numMenor)  //Si numero es menor a numMenor Entonces 
                {
                    numMenor = numero;  ////Si el número ingresado es menor al valor acumuludao de numMenor entonces se le asignará el valor de num a numMenor, de lo contrario no.
                }

                i = i + 1;  //Iterador, se le suma (+ 1) para llegar al valor establecido en la fucnión (5)
            }

            Console.WriteLine("El número mayor es: " + numMayor);  //Se muestra en pantalla el número mayor de la serie de cinco números.
            Console.WriteLine("El número menor es: " + numMenor);  //Se muestra en pantalla el número menor de la serie de cinco números.
        }
    }
}
