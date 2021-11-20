using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(-51, 51);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Array.Sort(arr, 0, 5);
            Array.Sort(arr, 5, 5);
            Array.Reverse(arr, 5, 5);
            Console.WriteLine("Отсортированный массив:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
