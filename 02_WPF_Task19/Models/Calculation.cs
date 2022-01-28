using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF_Task19.Models
{
    public static class Calculation
    {
        public static double Calculate(double r)
        {
            return Math.Round(2 * Math.PI * r, 2, MidpointRounding.AwayFromZero);
        }
    }
}
