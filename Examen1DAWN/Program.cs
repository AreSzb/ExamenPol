using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPol
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

            Console.WriteLine(cafetera.CantidadAgua);
            Console.WriteLine(cafetera.ConsumirCapsulas(5));
            Console.WriteLine(cafetera.TotalDeCapsulas);
            Console.WriteLine(cafetera.ConsumirAgua(5));
            Console.WriteLine(cafetera.CantidadAgua);

            cafetera.RellenarDeposito(0.5);

            Console.WriteLine(cafetera.CantidadAgua);

            cafetera.ReponerCapsulas(3);

            Console.WriteLine(cafetera.TotalDeCapsulas);
        }
    }
}
