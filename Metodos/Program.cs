using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana();
            calculadora.Mostrar();
            Console.ReadKey();
        }
        class ventana
        {
            private int _ancho;
            private int _altura;
            private string _color;

            public ventana()
            {
                _ancho = 15;
                _altura = 20;
                _color = "Rojo";
            }
            public void Mostrar()
            {
                Console.WriteLine("La dimension de la ventana es: " + _ancho +"x" + _altura + "Y su color es: " + _color);
            }
        }
    }
}
