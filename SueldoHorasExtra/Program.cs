using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoHorasExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es el sueldo base del trabajador: ");
            double salario= double.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas horas extras trabajo el empleado: ");
            double horasExtra = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el valor de la hora extra: ");
            double valorExtra= double.Parse(Console.ReadLine());

            double salarioFinal= PagoNomina(salario,horasExtra, valorExtra);
            Console.WriteLine("El salario del empleado es: {0}", salarioFinal);

            double bonoSalario = SalarioBono(horasExtra, salarioFinal);
            Console.WriteLine("El salario con bono es: {0}", bonoSalario);
        }

        public static double PagoNomina(double salario, double horasExtra, double valorExtra)
        {
            double pagoNomina = (horasExtra * valorExtra) + salario;
            return pagoNomina;
        }
        public static double SalarioBono(double horasExtra, double pagoNomina)
        {

            if (horasExtra >= 10 && horasExtra <=20)
            {
                double bono = pagoNomina * (0.04);
                return pagoNomina + bono;
            }
            else
            {
                if(horasExtra > 20)
                {
                    double bono = pagoNomina * (0.12);
                    return pagoNomina + bono;
                }
                else return pagoNomina;
            }
        }
    }
}
