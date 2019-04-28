using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    class Program
    {
        //Programa que lea una serie de números por teclado e indique cuál es el mayor
        static void Main(string[] args)
        {
            int mayorserie = 0;
            Console.WriteLine("Ingrese un la cantidad de numeros de la serie: ");
            int serie = Convert.ToInt16(Console.ReadLine());
            for(int i=0; i<serie; i++)
            {
                Console.WriteLine("Ingrese un la cantidad de numeros de la serie: " + i);
                int numero = Convert.ToInt32(Console.ReadLine());
           
                if (numero>mayorserie)
                {
                    mayorserie = numero;  
                }
            }
            Console.WriteLine("El numero mayor es: " + mayorserie);
            Console.ReadLine();
        }
    }
}
