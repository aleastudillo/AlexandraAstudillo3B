using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalFactura
{
    class Program
    {
        //Crear un programa que lea cantidades y precios y al final indique el total de la factura.
            //Primero se pregunta: 
                //Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
            //Después se pregunta:
                //Introduzca el precio que será un número decimal positivo.
                //La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.

        static void Main(string[] args)
        {
            int entero = 0;
            double precio = 0, total=0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese la cantidad vendida: ");
                    entero = Convert.ToInt16(Console.ReadLine());
                    if (entero < 0)
                    {
                        Console.Write("Cantidad no valida");
                    }
                } while (entero < 0);
                if (entero > 0)
                {
                    Console.WriteLine("Ingrese el precio: ");
                    do
                    {
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0)
                        {
                            Console.Write("Precio no valido");
                        }
                        else
                        {
                            total += entero * precio;
                        }
                    } while (precio < 0);
                }
            } while (entero != 0);

            Console.WriteLine("El Total vendido es: " + total);
            Console.ReadKey();
        }
    }
}
