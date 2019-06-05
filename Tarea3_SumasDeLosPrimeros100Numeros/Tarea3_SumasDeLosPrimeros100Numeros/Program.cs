using System;

namespace Tarea3_SumasDeLos_Primeros100Numeros
{
    class cienPrimerosnumeros
    {
        static int i, suma;
        static void Main(string[] args)
        {
            i = 1; //Iterador para el bucle while
            suma = 0;

            sumasDeNumeros();
            Console.ReadKey();
        }

        static private void sumasDeNumeros()
        {
            while (i <= 100)
            {
                suma = suma + i; //La variable suma me acumulará la suma de mi iterador.
                i = i + 1; //Mi variable i que es mi iterador me acumulara la suma de + 1 hasta llegar según la condición de While
                Console.WriteLine(suma); //Esto me mostrará en pantalla las sumas. 
            }
        }
    }

}
