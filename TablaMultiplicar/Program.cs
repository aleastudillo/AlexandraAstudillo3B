using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        //Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15
        static void Main(string[] args)
        {
            int numero=0 , multiplicacion = 0;

            Console.WriteLine("Multiplicacion: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 15; i++)
            {
                multiplicacion = numero * i;
                Console.WriteLine( i + "*" + numero + "=" + multiplicacion);
            }
            Console.ReadKey();
        }
    }
}
