using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public static class Circle
    {
        static double circleRadius;
        static double x;
        static double y;

        public static void CircleLength(double radius)
        {
            circleRadius = radius;
            double circleLength = Math.Round((2 * Math.PI * circleRadius), 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"При заданном радиусе длина окружности составляет {circleLength}");
        }
        public static void CircleSquare(double radius)
        {
            circleRadius = radius;
            double circleSquare = Math.Round((Math.PI * Math.Pow(circleRadius, 2)), 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"При заданном радиусе площадь окружности составляет {circleSquare}");
        }
        public static void PointBelong(double userX, double userY)
        {
            x = userX;
            y = userY;
            if (x <= circleRadius && y <= circleRadius)
                Console.WriteLine($"Заданная вами точка находится в пределах окружности с радиусом {circleRadius} и цетром в начале координат.");
            else
                Console.WriteLine($"Заданная вами точка находится вне пределов окружности с радиусом {circleRadius} и цетром в начале координат.");
        }

    }
}
