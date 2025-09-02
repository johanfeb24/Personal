using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaAprendizaje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique el precio de la tonelada: ");
            double tonelada = double.Parse(Console.ReadLine());
            Console.WriteLine("Indica la cantidad de kilogramos a comprar: ");
            double kilogramo = double.Parse(Console.ReadLine());

            double total = Toneladas(tonelada, kilogramo);

            Console.WriteLine("El total a pagar es {0}", total);
        }
        static double Toneladas(double tonelada, double kilogramos)
        {
            double precioKilogramo = tonelada / 1000;
            return precioKilogramo * kilogramos;
        }            
    }
}


