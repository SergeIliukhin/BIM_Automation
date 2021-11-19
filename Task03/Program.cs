using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты трёх вершин прямоугольника. Координатами вершин являются целые значения.");
            Console.WriteLine("Введите последовательно значения координат X и Y точки A:");
            int xA = int.Parse(Console.ReadLine());
            int yA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно значения координат X и Y точки B:");
            int xB = int.Parse(Console.ReadLine());
            int yB = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно значения координат X и Y точки С:");
            int xC = int.Parse(Console.ReadLine());
            int yC = int.Parse(Console.ReadLine());

            if (xA == xB && yB == yC)
            {
                int xD = xC;
                int yD = yA;
                Console.WriteLine($"Прямоугольник построить можно. Координаты четвертой вершины: ({xD},{yD})");
            }
            else
            {
                Console.WriteLine("Прямоугольник построить невозможно.");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Введите возраст человека в формате целого числа в диапазоне от 20 до 69 лет.");
            int age = int.Parse(Console.ReadLine());

            if (age == 20 || (age > 24 && age < 31) || (age > 34 && age < 41) || (age > 44 && age < 51) || (age > 54 && age < 61) || (age > 64 && age < 70))
            {
                Console.WriteLine($"Возраст человека: {age} лет.");
            }
            else if (age == 21 || age == 31 || age == 41 || age == 51 || age == 61)
            {
                Console.WriteLine($"Возраст человека: {age} год.");
            }
            else if ((age > 21 && age < 25) || (age > 31 && age < 35) || (age > 41 && age < 45) || (age > 51 && age < 55) || (age > 61 && age < 65))
            {
                Console.WriteLine($"Возраст человека: {age} года.");
            }
            else            
            {
                Console.WriteLine("Вы ввели неверное число");                
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
