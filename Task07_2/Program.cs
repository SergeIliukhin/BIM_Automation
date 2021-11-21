using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба:");
            double side = double.Parse(Console.ReadLine());

            GetCubeParameters(side, out double volume, out double sidesSquare);

            Console.WriteLine($"Объем куба составляет: {volume}.");
            Console.WriteLine($"Площадь поверхности куба составляет: {sidesSquare}.");

            Console.ReadKey();
        }
        static void GetCubeParameters(double side, out double volume, out double sidesSquare)
        {
            volume = Math.Round(Math.Pow(side, 3), 3, MidpointRounding.AwayFromZero);
            sidesSquare = Math.Round(6 * Math.Pow(side, 2), 3, MidpointRounding.AwayFromZero);
        }
    }
}
