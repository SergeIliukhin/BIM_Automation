using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string str = Console.ReadLine();
            string strNoSpace = str.Replace(" ", string.Empty);
            string strNoSpaceLower = strNoSpace.ToLower();

            char[] strArr = strNoSpaceLower.ToCharArray();
            Array.Reverse(strArr);

            string strReverced = "";
            foreach (char item in strArr)
            {
                strReverced += item;
            }
                        
            if (strNoSpaceLower == strReverced)
                Console.WriteLine("Введенное вами предложение является палиндромом");            
            else
                Console.WriteLine("Введенное вами предложение не является палиндромом");
                        
            Console.ReadKey();

        }
    }
}
