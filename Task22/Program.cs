using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество элементов массива:");
            int numberElements = int.Parse(Console.ReadLine());
            
            int[] array = new int[numberElements];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Исходный массив:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int sum = 0;
                        
            Action action = new Action(GetSum);
            Task task1 = new Task(action);

            Action<Task> actionTask = new Action<Task>(GetMaxValue);
            Task task2 = task1.ContinueWith(actionTask);

            task1.Start();

            void GetSum()
            {                
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];                    
                }
                Console.WriteLine($"Сумма всех элементов в массиве: {sum}.");                
            }

            void GetMaxValue(Task task)
            {
                Console.WriteLine($"Максимальное значение в массиве: {array.Max()}.");
            }

             
            Console.ReadKey();
        }
    }
}
