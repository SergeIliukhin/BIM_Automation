using System;
using System.Threading;
using System.Threading.Tasks;


namespace Task23
{
    class Program
    {
        //после каждого шага асинхронного метода текущее значение направляется в массив, размерность которого равна числу, факториал которого ищет пользователь
        public static void GetFactorial()
        {
            int current = 1;
            for (int i = 1; i <= UserArray.resultArray.Length; i++)
            {
                current *= i;
                UserArray.resultArray[i - 1] = current;
                Console.WriteLine($"Текущий факториал при работе асинхронного метода равен {current}.");
                Thread.Sleep(1000);
            }
        }

        static async void GetFactorialAsync()
        {
            Console.WriteLine("Начало асинхронного метода GetFactorialAsync");
            await Task.Run(() => GetFactorial());
            Console.WriteLine("Конец асинхронного метода GetFactorialAsync");
        }

        /*Немного искусственно, но запускаем проверку, сверяя новое вычисление в проверке с заполенным массивом после работы асинхронного метода.
         * Здесь главное, чтобы задержка при проверке была больше задержки при асинхронном вычислении.
         * Иначе проверка перейдет к следующему элементу контрольного массива прежде, чем асинхронный метод успеет туда записать значение.
         */
        static void CheckValue(int[] arr)
        {
            int checkCurrent = 1;
            for (int i = 1; i <= arr.Length; i++)
            {
                checkCurrent *= i;
                if (checkCurrent == arr[i-1])
                    Console.WriteLine($"Факториал после шага {i} равен {arr[i-1]}.");
                else
                    Console.WriteLine($"В шаге {i} ошибка.");
                Thread.Sleep(1300);
            }
            Console.WriteLine("Конец проверки.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого хотите вычислить:");
            int userNumber = int.Parse(Console.ReadLine());

            UserArray factorial = new UserArray(userNumber);

            GetFactorialAsync();

            CheckValue(UserArray.resultArray);


            Console.ReadKey();
        }
    }
}