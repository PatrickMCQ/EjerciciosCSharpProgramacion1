using System;

namespace Tarea18_Multiplos3UnidadTeclado
{
    class Program18
    {
        static float numero;
        static int conteo, i;
        static string entrada;
        static void Main(string[] args)
        {
            i = 3;  //Iterador del bucle, no se coloca uno pues no es mpultiplo de 3.
            conteo = 0;  //Esta variable contará las veces que se repita el bucle.
            entrada = "";  //Variable para entrada de datos.
            numero = 0;  //Variable útil para la conversión de string a float.

            multDeTresDesdeUno();
            Console.ReadKey();
        }

        static private void multDeTresDesdeUno()
        {
            Console.WriteLine("Ingrese un número para reconocer los múlitplos de tres desde la unidad hasta su número ingresado: ");  //Solicita al usuario ingresar dato.
            entrada = Console.ReadLine();  //El dato ingresado se asigna a entrada.
            numero = Convert.ToSingle(entrada);  //El dato se convierte de string a float y se le asigna a numero.

            while (i <= numero)  //Mientras i sea menor o igual a numero, hacer:
            {
                Console.WriteLine(i);  //Se muestra en pantalla el valor acumulado de i.
                i = i + 3;  //iterador, suma tres al valor acumulado para dar múltiplos de tres.
                conteo = conteo + 1;  //Se acumula en conteo las veces que se repite el ciclo.
            }

            Console.WriteLine("Hay un  total de: " + conteo + " múltiplos de 3, desde la unidad hasta " + numero);  //Muestra en pantalla el conteo.
        }
    }
}
