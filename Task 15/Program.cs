using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем случайное начало ряда
            Random rnd = new Random();
            int rndStart = rnd.Next(0, 100);

            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(rndStart);

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(rndStart);


            Console.WriteLine($"Первый ряд арифметической прогрессии с начальным значением {rndStart} и шагом 5:");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(arithProgression.GetNext() + " ");
            }

            Console.WriteLine(
                );
            Console.WriteLine($"Первый ряд геометической прогрессии с начальным значением {rndStart} и коэффициентом 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(geomProgression.GetNext() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            arithProgression.Reset();

            rndStart = rnd.Next(0, 100);

            arithProgression.SetStart(rndStart);

            Console.WriteLine($"Второй ряд арифметической прогрессии с начальным значением {rndStart} и шагом 5:");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(arithProgression.GetNext() + " ");
            }

            Console.WriteLine();
            
            Console.WriteLine($"Второй ряд геометической прогрессии с начальным значением {rndStart} и коэффициентом 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(geomProgression.GetNext() + " ");
            }

            Console.ReadKey();

        }
    }
}
