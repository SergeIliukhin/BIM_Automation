using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        delegate double Calculation(double radius);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double radius = double.Parse(Console.ReadLine());

            Calculation calcCircleLength = Circle.GetCircleLength;
            Calculation calcCircSquare = Circle.GetCircleSquare;
            Calculation calcSphereVolume = Circle.GetSphereVolume;

            Console.WriteLine("Длина окружности равна: " + calcCircleLength(radius) + ".");
            Console.WriteLine("Площадь круга равна: " + calcCircSquare(radius) + ".");
            Console.WriteLine("Объем шара равен: " + calcSphereVolume(radius) + ".");

            Console.ReadKey();
        }
    }
}
