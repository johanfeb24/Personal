using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoCompra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es el valor de la compra: ");
            double compra= double.Parse(Console.ReadLine());

            Descuento(compra);
        }

        public static void Descuento(double compra)
        {
            if (compra > 1000)
            {
                double total = compra * 1.20;
                Console.WriteLine($"El total de la compra es: {total}");
            }
            else
            {
                if (compra > 500 && compra <= 1000)
                {
                    double total = compra * 1.05;
                    Console.WriteLine($"El total de la compra es: {total}");
                }
                else { Console.WriteLine("No tienes descuento. Ajusta tu compra"); }
            }        

        }
    }
}
