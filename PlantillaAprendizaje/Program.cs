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
            int aprobados=0, noAprobados=0;
            Console.WriteLine("¿Cuantas notas desea ingresar?");
            int cantidadNotas=int.Parse(Console.ReadLine());

            for(int i=0; i<cantidadNotas; i++)
            {
                Console.WriteLine($"Ingrese la nota {i+1}: ");
                double nota=double.Parse(Console.ReadLine());

            if (nota >= 7)
                {
                    aprobados++;
                }
            else
                {
                    noAprobados++;
                }
            }
            Console.WriteLine("La cantidad de notas mayores a 7 es: {0}", aprobados);
            Console.WriteLine("La cantidad de notas menores a 7 es: {0}", noAprobados);
            Console.ReadLine();
        }
    }
}
