using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rombo
{
    class Program
    {
        //Modificar el ejercicio anterior para que aparezca un rombo

        static void Main(string[] args)
        {
            int fila;
            bool entra = false;
            do
            {
                Console.Write("Ingresar Numero Impar por favor: ");
                fila = Convert.ToInt32(Console.ReadLine());
                if (fila > 0 && fila % 2 != 0)
                {
                    entra = true;
                }
            } while (!entra);

            Console.Write("");

            int posicion = fila / 2 + 1;

            for (int i = 1; i <= posicion; i++)
            {
                for (int j = 1; j <= posicion - i; j++)
                {
                    Console.Write(" ");
                }
                for (int h = 1; h <= (2 * i) - 1; h++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            posicion--;

            for (int i = 1; i <= posicion; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int h = 1; h <= (posicion - i) * 2 + 1; h++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
         Console.ReadLine();
        }
    }
}
