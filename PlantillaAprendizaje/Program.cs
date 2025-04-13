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

            int pares=0, impares=0;

            Console.WriteLine("¿Cuantos numeros desea ingresar?");
            int cantidadNumeros=int.Parse(Console.ReadLine());
            
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine($"Ingrese por favor el dato {i+1}: ");
                int numero=int.Parse( Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;
                }
                else {impares++;}                
            }
            Console.WriteLine("La cantidad de numeros pares es: {0}", pares);
            Console.WriteLine("La cantidad de numeros impares es: {0}", impares);
            Console.ReadLine();
        }
    }
}


