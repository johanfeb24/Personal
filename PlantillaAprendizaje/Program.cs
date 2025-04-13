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

            double sumLista1=0, sumLista2=0;
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Ingrese por favor el dato {i+1} de la Lista # 1: ");
                int lista1=int.Parse( Console.ReadLine());
                sumLista1 += lista1;
            }
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Ingrese por favor el dato {j + 1} de la Lista # 2: ");
                int lista2 = int.Parse(Console.ReadLine());
                sumLista2 += lista2;
            }
            if (sumLista1 > sumLista2)
            {
                Console.WriteLine("La lista 1 tiene mayor acumulado: {0}", sumLista1);
            }
            else
            {
                if (sumLista1 < sumLista2)
                {
                    Console.WriteLine("La lista  2 tiene mayor acumulado: {0}", sumLista2);
                }
                else
                {
                    { Console.WriteLine("Las listas son iguales"); }
                }
            }
            Console.ReadLine();
        }
    }
}


