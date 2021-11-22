using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task08_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\BIM_Automation\task08_2.txt";

            //Создаем файл, если его нет
            if (!File.Exists(path))
                File.Create(path);

            //Создаем 10 случайных чисел
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }

            //Пишем созданные числа в файл
            using (StreamWriter sw = new StreamWriter(path))
                foreach (int item in arr)
                    sw.Write($"{item} ");

            //Читаем данные из файла
            string fileData;

            using (StreamReader sr = new StreamReader(path))
            {
                fileData = sr.ReadToEnd();                
            }

            string fileDataTrimmed = fileData.Trim();

            string[] fileDataText = fileDataTrimmed.Split();

            int count = 0;

            Console.WriteLine("Исходный набор чисел из файла:");
            
            foreach (string item in fileDataText)
            {
                    item.Trim();
                    Console.Write($"{item} ");
                    count += 1;
            }
                            
            //Преобразуем полученные данные в числа и получаем сумму
            int[] fileDataNumbers = new int[count];

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                fileDataNumbers[i] = int.Parse(fileDataText[i]);
                sum += fileDataNumbers[i];
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма полученных из файла чисел составляет: {sum}.");
            
            
            


        }
    }
}
