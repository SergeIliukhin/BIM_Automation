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
            Console.WriteLine("Введите предложение:");
            string str = Console.ReadLine();
            string[] strArr = str.Split();
            int wordLen = 0;
            string strResult = "";
            foreach (string item in strArr)
            {
                if (item.Length > wordLen)
                {
                    wordLen = item.Length;
                    strResult = item;
                }
            }
            Console.WriteLine($"Самое длинное слово в предложении: \"{strResult}\". Количество символов: {wordLen}.");
        }
    }
}
