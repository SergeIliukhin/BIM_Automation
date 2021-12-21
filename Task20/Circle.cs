using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Circle
    {
        public static double Radius { get; private set; }
        public static double GetCircleLength (double radius)
        {
            Radius = radius;
            return Math.Round(2 * Math.PI * Radius, 2, MidpointRounding.AwayFromZero);
        }
        public static double GetCircleSquare(double radius)
        {
            Radius = radius;
            return Math.Round(Math.PI * Math.Pow(Radius,2), 2, MidpointRounding.AwayFromZero);
        }
        public static double GetSphereVolume(double radius)
        {
            Radius = radius;
            return Math.Round((4 * Math.PI * Math.Pow(Radius, 3) / 3), 2, MidpointRounding.AwayFromZero);
        }
    }
}
