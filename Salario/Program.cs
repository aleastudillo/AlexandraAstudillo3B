using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        //Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares 
        //por hora si éstas no superan las 35 horas. Cada hora por encima de 35 se considerará extra y 
        //se paga a 22 dólares. 
        //El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
        //Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite

        static void Main(string[] args)
        {
            int horas =0, salario=0, extras;
            Console.Write("Introduce La cantiad de horas: ");
            horas = Convert.ToInt32(Console.ReadLine());
              
            if (horas <= 35)
            {
                salario = (horas * 15);
            }
            else
            {
                extras = (horas - 35) * 22;

                salario = (extras + (35 * 15));
            }
            Console.WriteLine("El Salario es de:" + salario);


            Console.WriteLine("Desea Realizar otro calculo: 1=SI   0=NO ");
            int ban = Convert.ToInt32(Console.ReadLine());
            if (ban==1)
            {
                Console.Write("Introduce La cantiad de horas: ");
                horas = Convert.ToInt32(Console.ReadLine());
                if (horas <= 35)
                {
                    salario = (horas * 15);
                }
                else
                {
                    extras = (horas - 35) * 22;

                    salario = (extras + (35 * 15));
                }
                Console.WriteLine("El Salario es de:" + salario);
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
