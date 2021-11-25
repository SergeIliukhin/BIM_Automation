using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIntX = false;
            bool isIntY = false;
            int xTrue = 0;
            int yTrue = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите первое целое число \"x\" в диапазоне Int32.");
                    int x = int.Parse(Console.ReadLine());
                    isIntX = true;
                    xTrue = x;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенное вами значение не является целым числом. Повторите ввод.");
                    Console.WriteLine();
                }
            } while (isIntX == false);

            do
            {
                try
                {
                    Console.WriteLine("Введите второе целое число \"y\" в диапазоне Int32.");
                    int y = int.Parse(Console.ReadLine());
                    isIntY = true;
                    yTrue = y;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенное вами значение не является целым числом. Повторите ввод.");
                    Console.WriteLine();
                }
            } while (isIntY == false);

            Console.WriteLine("Введите код операции:");
            Console.WriteLine("\t1 - сложение;");
            Console.WriteLine("\t2 - вычитание;");
            Console.WriteLine("\t3 - умножение;");
            Console.WriteLine("\t4 - деление.");
                        
            bool isChoiseTrue = false;
            int choiceTrue = 0;

            do
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    while (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Введенное вами значение не лежит в диапазоне от 1 до 4. Повторите ввод.");
                        choice = int.Parse(Console.ReadLine());
                    }
                    isChoiseTrue = true;
                    choiceTrue = choice;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенное вами значение не является целым числом. Повторите ввод.");
                    Console.WriteLine();
                    isChoiseTrue = false;
                }
            } while (isChoiseTrue == false);

            int resultInt;
            double resultDouble;

            switch (choiceTrue)
            {
                case 1:
                    resultInt = xTrue + yTrue;
                    Console.WriteLine($"Ответ: {resultInt}.");
                    break;
                case 2:
                    resultInt = xTrue - yTrue;
                    Console.WriteLine($"Ответ: {resultInt}.");
                    break;
                case 3:          
                    //Можно добавить защиту от переполнения
                    resultInt = xTrue * yTrue;                    
                    Console.WriteLine($"Ответ: {resultInt}.");
                    break;
                case 4:
                    try
                    {
                        resultInt = xTrue / yTrue;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Вы пытаетесь делить на 0.");
                        break;
                    }
                    resultDouble = Math.Round((double)xTrue / (double)yTrue, 3, MidpointRounding.AwayFromZero);
                    Console.WriteLine($"Ответ: {resultDouble}.");
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
