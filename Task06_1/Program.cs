using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Защиту от пустого предложения не предусматриваем

            Console.WriteLine("Введите предложение:");
            string str = Console.ReadLine();
            string[] strArr = str.Split();
            
            int wordLongestLen = 0;
            int countLongestWords = 0;
            string strResult = "";
            //string strResultMultiple = "";

            //Считаем максимальное число символов отдельно взятого слова в строке
            foreach (string item in strArr)
            {
                if (item.Length > wordLongestLen)
                {
                    wordLongestLen = item.Length;                    
                }                
            }

            //Считаем количество слов с максимальной длиной и добавляем их в итоговую строку с ответом
            foreach (string item in strArr)
            {
                if (item.Length == wordLongestLen)
                {
                    countLongestWords += 1;
                    strResult = strResult + item + ", ";
                }
            }

            string strResultTrimmed = strResult.Remove(strResult.Length - 2, 2);

            //Выводим результат в зависимости от того, сколько слов с одинаковой длиной нашлось
            if (countLongestWords == 1)
                Console.WriteLine($"Самое длинное слово в предложении: \"{strResultTrimmed}\". Количество символов: {wordLongestLen}.");
            else
                Console.WriteLine($"Самые длинные слова в предложении: \"{strResultTrimmed}\". Количество символов: {wordLongestLen}.");

            Console.ReadKey();
        }
    }
}
