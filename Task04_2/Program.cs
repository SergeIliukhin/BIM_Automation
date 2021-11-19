using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveNumbers = 0;
            int negativeNumbers = 0;
            int stop = 0;
            Console.WriteLine("Введите любое целое число:");
            do
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    positiveNumbers += 1;                    
                }
                else if (number < 0)
                {
                    negativeNumbers += 1;                    
                }
                else
                    stop = 1;                    
            } while (stop != 1);
            if (positiveNumbers > negativeNumbers)
            {
                Console.WriteLine($"Положительных чисел ({positiveNumbers}) больше, чем отрицательных ({negativeNumbers}).");
            }
            else if (positiveNumbers < negativeNumbers)
            {
                Console.WriteLine($"Положительных чисел ({positiveNumbers}) меньше, чем отрицательных ({negativeNumbers}).");
            }
            else
            {
                Console.WriteLine($"Положительных чисел столько же, сколько отрицательных ({positiveNumbers}).");
            }
            Console.ReadKey();
        }
    }
}
