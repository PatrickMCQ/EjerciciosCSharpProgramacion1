using System;

namespace Tarea_1_Impresion_de_numeros_del_0_al_100
{
    class numeros0a100
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 100)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            Console.ReadKey();
        }

    }
}
