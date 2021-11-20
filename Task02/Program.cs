using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длину окружности: ");
            double lengthOfCircle = double.Parse(Console.ReadLine());
            
            double radiusOfCircle = Math.Round(lengthOfCircle / (2 * Math.PI), 3, MidpointRounding.AwayFromZero);
            double squareOfCircle = Math.Round(Math.PI * Math.Pow(radiusOfCircle, 2), 3, MidpointRounding.AwayFromZero);
            
            Console.WriteLine($"Радиус окружности равен: {radiusOfCircle}. Площадь круга равна: {squareOfCircle}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Дан прямоугольник ABCD. Координатами вершин являются целые значения.");
            Console.WriteLine("Введите последовательно значения координат X и Y точки A:");
            int xA = int.Parse(Console.ReadLine());
            int yA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно значения координат X и Y точки С:");
            int xC = int.Parse(Console.ReadLine());
            int yC = int.Parse(Console.ReadLine());

            //Комментарий преподавателя: "расстояние лучше считать по модулю, т.к. мы не знаем, как точки будут расположены друг относительно друга"
            int AB = yC - yA;
            int AD = xC - xA;

            int perimeterOfRectangle = 2 * AB + 2 * AD;
            int squareOfRectangle = AB * AD;

            Console.WriteLine($"Периметр прямоугольника равен: {perimeterOfRectangle}. Площадь прямоугольника равна: {squareOfRectangle}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();
            
            Console.WriteLine("Дан треугольник EFG.");
            Console.WriteLine("Введите последовательно значения координат X и Y точки E:");
            double xE = int.Parse(Console.ReadLine());
            double yE = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно значения координат X и Y точки F:");
            double xF = int.Parse(Console.ReadLine());
            double yF = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно значения координат X и Y точки G:");
            double xG = int.Parse(Console.ReadLine());
            double yG = int.Parse(Console.ReadLine());

            double EF = Math.Abs(Math.Sqrt(Math.Pow(xF - xE, 2) + Math.Pow(yF - yE, 2)));
            double FG = Math.Abs(Math.Sqrt(Math.Pow(xG - xF, 2) + Math.Pow(yG - yF, 2)));
            double EG = Math.Abs(Math.Sqrt(Math.Pow(xG - xE, 2) + Math.Pow(yG - yE, 2)));

            double perimeterOfTriangle = Math.Round(Math.Abs(EF) + Math.Abs(FG) + Math.Abs(EG), 3, MidpointRounding.AwayFromZero);
            double halfPerimeterOfTriangle = 0.5 * (EF + FG + EG);
            double squareOfTriangle = Math.Round(Math.Sqrt(halfPerimeterOfTriangle * (halfPerimeterOfTriangle - EF) * (halfPerimeterOfTriangle - FG) * (halfPerimeterOfTriangle - EG)), 3, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Периметр треугольника равен: {perimeterOfTriangle}. Площадь треугольника равна: {squareOfTriangle}");
            

        }
    }
}
