using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        private static int[,] site;        

        static void Main()
        {
            site = new int[20, 20];

            Thread gardener1 = new Thread(Plant1);
            Thread gardener2 = new Thread(Plant2);

            gardener1.Start();
            gardener2.Start();

            gardener1.Join();
            gardener2.Join();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(site[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void Plant1()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (site[i, j] == 0)
                        site[i, j] = 1;
                    Thread.Sleep(1);
                }
            }
        }

        private static void Plant2()
        {
            for (int i = 19; i > 0; i--)
            {
                for (int j = 19; j > 0; j--)
                {
                    if (site[j, i] == 0)
                        site[j, i] = 5;
                    Thread.Sleep(1);
                }
            }
        }
    }
}
