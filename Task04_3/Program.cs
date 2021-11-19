using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три положительных числа.");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int countLength = 0;
            int length = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            int height = (length == firstNumber) ? secondNumber : firstNumber;

            while (length >= thirdNumber)
            {
                countLength += 1;
                length -= thirdNumber;                
            }
            int result = countLength;
            while (height- thirdNumber >= thirdNumber)
            {
                result += countLength;
                height -= thirdNumber;
            }

            Console.WriteLine($"В прямоугольник со сторонами {firstNumber} и {secondNumber} поместится {result} квадратов со стороной {thirdNumber}");
            Console.ReadKey();
        }
    }
}
