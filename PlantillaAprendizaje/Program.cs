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
            double sumAltura=0, promAltura;
            Console.WriteLine("¿Cuantas alturas desea ingresar?");
            int cantAlturas= int.Parse(Console.ReadLine());

            for(int i=0; i<cantAlturas; i++)
            {
                Console.WriteLine($"Ingrese la altura {i+1}: ");
                double altura=double.Parse(Console.ReadLine());
                sumAltura += altura;                
            }
            promAltura = sumAltura / cantAlturas;
            Console.WriteLine($"El promedio de altura de las personas censadas es: {promAltura}");
            Console. ReadLine();
        }
            
    }
}
