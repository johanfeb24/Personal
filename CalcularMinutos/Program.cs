using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMinutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el tiempo a calcular: ");
            int tiempo= int.Parse(Console.ReadLine());

            TiempoEnMinutos(tiempo);
        }
        public static void TiempoEnMinutos(int tiempo)
        {
            int tiempoDias = tiempo / 1440;
            int restanteTiempo = tiempo % 1440;
            int horas = restanteTiempo / 60;
            int minutos= restanteTiempo % 60;

            Console.WriteLine($"{tiempo} minutos equivalen a {tiempoDias} días {horas} horas y {minutos} minutos");
        }
    }
}