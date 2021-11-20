using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rand.Next(-51, 51);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            
            int count = 0;
            int position = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0 && arr[i] % 2 != 0 && arr[i] > 0)
                {
                    position += 1;
                    //Считаем места привычным способом, начиная с первой, а не с нулевой, как видит компьютер (отсюда i+1)
                    Console.WriteLine($"{position} искомый элемент равен {arr[i]} и находится на позиции {i + 1}.");                    
                    count += 1;
                }
            }

            Console.WriteLine($"Количество нечетных положительных элементов, стоящих на четных местах, равно: {count}.");
            Console.ReadKey();
        }
    }
}
