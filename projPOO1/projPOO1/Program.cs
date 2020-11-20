using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1;

            ret1 = new Retangulo();

            Console.Write("Informe a base do retângulo: ");
            ret1.setBase(int.Parse(Console.ReadLine()));

            Console.Write("Informe a altura do retângulo: ");
            ret1.setAltura(int.Parse(Console.ReadLine()));

            ret1.calcularArea();

            Console.WriteLine("Um retângulo que tem base {0} e altura {1} tem área: {2} ", 
                ret1.getBase(), ret1.getAltura(), ret1.getArea());

            Console.ReadKey();
        }
    }
}
