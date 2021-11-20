using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            int number = int.Parse(Console.ReadLine());

            int[,] arr = new int[number, number];            

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                        arr[i, j] = 1;                    
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
