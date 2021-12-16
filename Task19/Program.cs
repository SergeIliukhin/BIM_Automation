using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            char[] strToChar = str.ToCharArray();

            List<char> bracketsResult = new List<char>();

            Stack<char> bracketsChars = new Stack<char>();

            Dictionary<char, char> bracketsSymbols = new Dictionary<char, char>(3);
            bracketsSymbols.Add('(', ')');
            bracketsSymbols.Add('[', ']');
            bracketsSymbols.Add('{', '}');

            bool result = true;
            int countOfBrackets = 0;

            foreach (char item in strToChar)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    bracketsChars.Push(bracketsSymbols[item]);
                    result = false;
                    bracketsResult.Add(item);
                    countOfBrackets += 1;
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    try
                    {
                        char test = bracketsChars.Peek();

                        if (bracketsChars.Peek() == item)
                        {
                            bracketsChars.Pop();
                            result = true;
                            bracketsResult.Add(item);
                            countOfBrackets += 1;
                        }
                    }
                    catch (Exception)
                    {
                        bracketsResult.Add(item);
                        result = false;
                        countOfBrackets += 1;
                    }
                }
            }

            if (countOfBrackets > 0 && result == true)
            {
                Console.Write("В вашей строке последовательность скобок правильная: ");

                foreach (var bracket in bracketsResult)
                {
                    Console.Write(bracket);
                }
            }

            else if (countOfBrackets > 0 && result == false)
            {
                Console.Write("В вашей строке последовательность скобок неправильная: ");

                foreach (var bracket in bracketsResult)
                {
                    Console.Write(bracket);
                }
            }

            else
                Console.WriteLine("В вашей строке нет скобок.");

            Console.ReadKey();

        }
    }
}
