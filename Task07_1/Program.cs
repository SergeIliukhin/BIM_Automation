using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно длины сторон первого треугольника:");
            double firstA = double.Parse(Console.ReadLine());
            double firstB = double.Parse(Console.ReadLine());
            double firstC = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно длины сторон первого треугольника:");
            double secondA = double.Parse(Console.ReadLine());
            double secondB = double.Parse(Console.ReadLine());
            double secondC = double.Parse(Console.ReadLine());

            double firstSquare = GetSquare(firstA, firstB, firstC);
            double secondSquare = GetSquare(secondA, secondB, secondC);

            if (firstSquare > secondSquare)
                Console.WriteLine($"Площадь первого треугольника ({firstSquare}) больше площади второго треугольника ({secondSquare}).");
            else if (secondSquare > firstSquare)
                Console.WriteLine($"Площадь первого треугольника ({firstSquare}) меньше площади второго треугольника ({secondSquare}).");
            else
                Console.WriteLine($"Площади треугольников равны и составляют: {firstSquare}.");

            Console.ReadKey();
        }


        static double GetSquare (double a, double b, double c)
        {
            double halfPerimeterOfTriangle = 0.5 * (a + b + c);
            double squareOfTriangle = Math.Round(Math.Sqrt(halfPerimeterOfTriangle * (halfPerimeterOfTriangle - a) * (halfPerimeterOfTriangle - b) * (halfPerimeterOfTriangle - c)), 3, MidpointRounding.AwayFromZero);
            return squareOfTriangle;
        }

    }
}
