using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoDosTres
{
    class Program
    {
        //Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. 
        //La primera cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna 
        //cuenta de dos en dos y la tercera de tres.

        static void Main(string[] args)
        {
            int i1 = 0, i2 = 0;
            Console.WriteLine("Ingrese un la cantidad de numeros de la serie: ");
            int entero = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= entero; i++)
            {
                i1 = ((i + 2) + i);
                i2 = ((i +3) + i +i);
                Console.WriteLine((i) + "  " + "  " + "  " + (i1) + "  " + "  " + "  " +(i2));
            }
            Console.ReadKey();
        }
    }
}
