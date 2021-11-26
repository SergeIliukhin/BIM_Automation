using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано линейное уравнение kx + b = 0. Требуется найти \"x\" при заданных параметрах \"k\" и \"b\".");
            Console.WriteLine("Введите значение \"k\":");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение \"b\":");
            double b = double.Parse(Console.ReadLine());

            LinearEquation lin = new LinearEquation();
            lin.k = k;
            lin.b = b;

            lin.Root();

            Console.ReadKey();

        }
    }
}
