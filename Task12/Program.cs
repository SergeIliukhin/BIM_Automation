using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значени радиуса окружности:");
            double radius = double.Parse(Console.ReadLine());

            Circle.CircleLength(radius);
            Circle.CircleSquare(radius);

            Console.WriteLine();

            Console.WriteLine("Введите последовательно две координаты точки \"x\" и \"y\":");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Circle.PointBelong(x, y);

            Console.ReadKey();
        }
    }
}
