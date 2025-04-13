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
            double area, perimetro;

            Console.WriteLine("Por favor digite la base del rectangulo: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor digite la altura del rectangulo: ");
            double h=double.Parse(Console.ReadLine());

            area = b * h;
            perimetro = 2 * (b + h);

            Console.WriteLine("El area del rectangulo es: {0} cm² y el perimetro es: {1} cm", area,perimetro); //Para agregar el cuadrado oprimimos ALT + 253
            Console.ReadLine();
        }
    }
}


