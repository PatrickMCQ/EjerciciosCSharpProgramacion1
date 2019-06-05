using System;

namespace Tarea5_ImparesHasta100yContarlos
{
    class imparesa100
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 1; //Iterador del bucle while
            conteo = 0; //contador del bucle while

            numerosImparesHasta100YConteo();
            Console.ReadKey();
        }

        static private void numerosImparesHasta100YConteo()
        {
            while (i <= 100)
            {
                Console.WriteLine(i); //Se mostrará en pantalla el valor acumulado de i
                i = i + 2;  //Se acumulará en i la suma de + 2 para tomar unicamente impares de 1 a 100
                conteo = conteo + 1;  //Se acumulará en conteo el número de veces que se repite el ciclo
            }

            Console.WriteLine("Existe un total de: " + conteo + " números impares");  //Se mostrará en pantalla el total de impares que hay
        }
    }
}
