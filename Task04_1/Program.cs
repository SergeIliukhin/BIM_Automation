using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");           
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= (2*number - 1); i+=2)
            {
                result += i;
                Console.WriteLine(result);
            }
        }
    }
}
