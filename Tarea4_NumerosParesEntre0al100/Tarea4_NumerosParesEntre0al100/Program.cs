using System;

namespace Tarea4_NumerosParesEntre0al100
{
    class numerosPares
    {
        static int i;
        static void Main(string[] args)
        {
            i = 0;

            numerosPares0al100();
            Console.ReadKey();
        }

        static private void numerosPares0al100()
        {
            while (i <= 100)
            {
                Console.WriteLine(i); //Me mostrará en pantalla lo acumulado de i
                i = i + 2; //La variable i me acumulará la suma +2 hasta que se detenga según la condicón de While
            }
        }
    }
}

