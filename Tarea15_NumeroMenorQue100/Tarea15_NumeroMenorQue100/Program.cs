using System;

namespace Tarea15_numeroMenorQue100
{
    class Program15
    {
        static int potencia;
        static string entrada;
        static float i, suma, numero;
        static double datos;
        static void Main(string[] args)
        {
            i = 0;  //Iterador del bucle while del método cuadradosDeNumeros4Posiciones() 
            entrada = "";  //Variable para entrada de datos, del método ingresoDeNumeroMenor100();
            numero = 0;  //Variable útil para conversion. 

            ingresoDeNumeroMenor100();
            cuadradosDeNumeros4Posiciones();
            Console.ReadKey();
        }

        static private void ingresoDeNumeroMenor100()
        {
            Console.WriteLine("Ingrese un número menor que 100: ");  //Se solicita al usuario el ingreso de un número menor que 100.
            entrada = Console.ReadLine();  //El dato ingresado se asigna a entrada.
            numero = Convert.ToSingle(entrada);  //se convierte de cadena a float y se le asigna el dato float a numero.

            while (i > 100)  //Mientras i sea mayor a 100, hacer:
            {
                Console.WriteLine("El número ingresado es mayor que 100, ingrese un número menor que 100: ");  //Numero mayor a 100, se solicita nuevo número.
                entrada = Console.ReadLine();  ////El dato ingresado se asigna a entrada.
                numero = Convert.ToSingle(entrada);  //se convierte de cadena a float y se le asigna el dato float a numero.
            }
        }

        static private void cuadradosDeNumeros4Posiciones()
        {
            i = numero;  //Se le asigna a i el valor de numero.
            while (i <= 100)  //Mientras i sea menor o igual que 100, hacer:
            {
                datos = Math.Pow(i, 2);  //La variable numeros acumularáel cuadrado del valor de i, se utiliza el metodo pow para potencia.
                potencia = Convert.ToInt32(datos);  //Se convierte el valor de numeros de double a int y se le asigna el valor acumulado a potencia.
                Console.WriteLine(i);  //Se muestra el valor acumulado de i.
                suma = suma + potencia;  //Se suma el valor acumulado en suma  más el valor acumulado en potencia.
                i = i + 4;  //Me va iterando sumanod (+ 4) para separar los numeros 4 psosiciones.
            }

            Console.WriteLine("La suma de los cuadrados de los numeros que estan separados entres sí cuatro posiciones es de: " + suma);
            //Muestra en pantalla la suma de los cuadrados de los numeros separados entre sí 4 posiciones.


        }
    }
}
