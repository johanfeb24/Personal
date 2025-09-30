using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana(); //Objeto (Ventana= Clase // caluladora= instancia de la clase ventana)
            calculadora.Minimizar();
            Console.ReadKey();
        }
        public class ventana
        {
            //Atributos
            public int ancho, altura;
            private string _color = "Azul";

            //Metodos
            public void Cerrar()
            {
                Console.WriteLine("La ventrana se cerro!");
            }

            public void Minimizar()
            {
                Console.WriteLine("La ventana se miniomizo");
            }

            public void Maximizar()
            {
                Console.WriteLine("La ventana se agrando");
            }
        }
    }

}
