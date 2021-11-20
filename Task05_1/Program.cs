using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Console.WriteLine("Введите семь целых чисел:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            double average;
            foreach (var item in arr)
            {
                sum += item;
            }
            average = (double)sum / arr.Length;
            Console.WriteLine($"Среднее арифметическое введенных вами чисел : {average}");
            Console.ReadKey();
        }
    }
}
