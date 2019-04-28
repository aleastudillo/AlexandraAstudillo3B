using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class Program
    {
        //Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese 
        //tamaño. Los asteriscos sólo se verán en el borde del cuadrado, no en el interior
        static void Main(string[] args)
        {
            Console.Write("Introduce el lado del cuadrado: ");
            int lado = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= lado; i++)
            {
                for (int j = 1; j <= lado; j++)
                {
                    if (i == 1 || j == 1)
                    { 
                        Console.Write("* ");
                    }
                    else
                    {
                        if (i == lado || j == lado)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine("");                
            }
            Console.ReadKey();

        }
    }
}
