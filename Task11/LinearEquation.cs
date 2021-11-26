using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public struct LinearEquation
    {
        public double k;
        public double b;
        private double x;
        
        public void Root()
        {            
            if (k != 0)
            {
                x = Math.Round(-k / b, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"X равен {x}.");
            }
            else if (k == 0 && b != 0)
            {
                Console.WriteLine("Решений уравнения нет.");
            }
            else if (k == 0 && b == 0)
            {
                Console.WriteLine("Решением уравнения может быть любое число.");
            }            
        }
    }
}
