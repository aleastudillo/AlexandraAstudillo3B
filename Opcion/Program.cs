using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcion
{
    class Program
    {
        //Crear un programa que muestre un menú como este: 1) Salir     2) Sumatorio        3) Factorial
        //Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.
        //Si se elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial(en ambos casos el 
        //programa pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). 
        //Tras calcular el sumatorio o la factorial e indicar el resultado, el programa volverá a mostrar el menú y 
        //así sucesivamente.

        static void Main(string[] args)
        {
            int suma = 0, factorial = 1, fac = 0;
            Console.Write("MENÚ DE OPCIONES");
            Console.WriteLine("  ");
            Console.Write("1) Salir");
            Console.WriteLine("  ");
            Console.Write("2) Sumatorio");
            Console.WriteLine("  ");
            Console.Write("3) Factorial");
            Console.WriteLine(" \n");
            Console.WriteLine("Ingrese Opción: ");
            int op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Environment.Exit(0);
                break;
                case 2:
                    Console.WriteLine("Ingrese cantidad a sumar: ");
                    int entero = Convert.ToInt16(Console.ReadLine());
                    for (int i = 1; i <= entero; i++)
                    {
                        suma = suma + entero;
                    }
                    Console.WriteLine("La Sumatoria es: "+suma);
                break;
                case 3:
                    for (int i = 1; i <= fac; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("El factorial es: "+factorial);
                    break;
                default:
                    Environment.Exit(0);
                break;
            }
            Console.ReadKey();
        }
    }
}
