using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random rand = new Random();

            for (int i = 0; i < 15; i++)
            {
                arr[i] = rand.Next(0,51);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Array.Sort(arr);
            int sum = arr[0] + arr[14];
            Console.WriteLine($"Минимальное значение в массиве: {arr[0]}");
            Console.WriteLine($"Максимальное значение в массиве: {arr[14]}");
            Console.WriteLine($"Их сумма: {sum}");
            Console.ReadKey();
        }
    }
}
