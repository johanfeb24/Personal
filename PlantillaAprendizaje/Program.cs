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
            double valorFinal;

            Console.WriteLine("Por favor indique la cantidad de dinero: ");
            double dinero=double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el porcentaje que desea aplicar: ");
            double porcentaje=double.Parse(Console.ReadLine());

            valorFinal = porcentaje / 100 * (dinero);

            Console.WriteLine("El {0}%  de {1} es {2}", porcentaje,dinero,valorFinal);
            Console.ReadLine();
        }
    }
}


