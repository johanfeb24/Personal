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
            double importe = 0, empleadoCatg1 = 0, empleadoCatg2 = 0;
            Console.WriteLine("¿Cuántos empleados trabajan en la empresa?");
            int cantEmpleados = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantEmpleados; i++)
            {
                double salario;
                while (true) // Bucle para validar el salario
                {
                    Console.WriteLine($"Ingrese el salario del empleado # {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out salario))
                    {
                        if (salario >= 100)
                        {
                            break; // Salimos del bucle si el salario es válido
                        }
                        else
                        {
                            Console.WriteLine("No tenemos un salario tan bajo en la empresa. Ingrese un valor válido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Ingrese un número.");
                    }
                }

                importe += salario;

                if (salario >= 100 && salario <= 300)
                {
                    empleadoCatg1++;
                }
                else
                {
                    empleadoCatg2++;
                }
            }

            Console.WriteLine($"La cantidad de empleados que ganan entre $100 y $300 es: {empleadoCatg1}");
            Console.WriteLine($"La cantidad de empleados que ganan más de $300 es: {empleadoCatg2}");
            Console.WriteLine($"El importe total de la empresa es: {importe}");
            Console.ReadLine();
        }
    }
}


