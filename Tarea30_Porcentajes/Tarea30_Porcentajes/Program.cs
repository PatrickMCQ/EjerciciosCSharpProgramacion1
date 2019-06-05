using System;

namespace Tarea30_Porcentajes
{
    class Program
    {
        static float cantidad, porcentaje50, porcentaje7, restaPorcentaje5, sumaPorcentaje50, sumaPorcentaje7, porcentaje5;
        static string entrada;
        static void Main(string[] args)
        {
            //Asignanción de variables
            cantidad = 0;
            porcentaje50 = 0;
            sumaPorcentaje50 = 0;
            porcentaje7 = 0;
            restaPorcentaje5 = 0;
            porcentaje7 = 0;
            porcentaje5 = 0;
            sumaPorcentaje7 = 0;
            entrada = "";

            porcentajes();
            Console.ReadKey();
        }

        static private void porcentajes()
        {
            Console.WriteLine("Ingrese una cantidad: ");  //Se solicita el ingreso de una cantidad.
            entrada = Console.ReadLine();  //A entrada se le asignará la cantidad ingresada.
            cantidad = Convert.ToSingle(entrada);  //El dato se convierte de string a float y se le asigna a cantidad.

            //El 50 Porciento
            if (cantidad < 500)  //Si cantidad es menor que 500 Entonces
            {
                porcentaje50 = cantidad * 0.5f;  //Se le saca el 50 porciento a cantidad.
                sumaPorcentaje50 = cantidad + porcentaje50;  //Se le suma el 50 porciento a cantidad.
                Console.WriteLine("La suma del 50 porciento es de: " + sumaPorcentaje50);  //Se muestra la cantidad luego de lo realiazado
            }
            else
            {
                Console.WriteLine(cantidad + " no es menor que 500");  //Sino, se muestra un mensaje 
            }

            //El 7 Porciento
            if ((cantidad >= 500) && (cantidad < 1000))  //Si cantidad es mayor o igual a 500 Y es menor a 100 Entonces
            {
                porcentaje7 = cantidad * 0.07f;  //Se le saca el 7 prociento a cantidad.
                sumaPorcentaje7 = cantidad + porcentaje7;  //Se le suma el 7 porciento a cantidad.
                Console.WriteLine("La suma del 7 porciento es de: " + sumaPorcentaje7);  // Se muestra la cantidad luego de realizado.
            }
            else
            {
                Console.WriteLine("Pueda que su cantidad no sea mayor o igual que 500, o no sea menor que 1000 ");  //Sino, se muestra un mensaje.
            }

            //El 5 Porciento
            if ((cantidad > 1000) && (cantidad <= 5000))  //Si cantidad es mayor que 100 Y es menor o igual que 5000 Entonces
            {
                porcentaje5 = cantidad * 0.05f;  //Se le saca el 5 porciento a cantidad.
                restaPorcentaje5 = cantidad - porcentaje5;  //Se le resta el 5 porciento a cantidad.
                Console.WriteLine("La resta del 5 porciento es de: " + restaPorcentaje5);  //Se muestra la cantidad luego de realizado.
            }
            else
            {
                Console.WriteLine("Pueda ser que la cantidad no sea mayor que 1000, o no sea menor o igual que 5000");  //Sino, se muestra un mensaje.
            }

        }

    }
}
