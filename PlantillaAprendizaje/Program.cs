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
            Console.WriteLine("Ingrese la coordenada X1: ");
            double X1= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada Y1: ");
            double Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la corrdenada X2: ");
            double X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la corrdenada Y2: ");
            double Y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));

            Console.WriteLine($"La distancia entre los dos puntos es: {distancia:F2}");
            Console.ReadLine();
        }
    }
}


