using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> listPC = new List<PC>()
            {
                new PC(){ID = 1, Name = "Variant1", ProcessorType = "Intel", ProcessorFrequency = 1.5, RAMSize = 8, HDDSize = 120, VGASize = 2, Price = 30000, Quantity = 12},
                new PC(){ID = 2, Name = "Variant2", ProcessorType = "Intel", ProcessorFrequency = 2.0, RAMSize = 16, HDDSize = 240, VGASize = 6, Price = 60000, Quantity = 25},
                new PC(){ID = 3, Name = "Variant3", ProcessorType = "Intel", ProcessorFrequency = 3.5, RAMSize = 32, HDDSize = 1024, VGASize = 8, Price = 120000, Quantity = 48},
                new PC(){ID = 4, Name = "Variant4", ProcessorType = "AMD", ProcessorFrequency = 2.0, RAMSize = 8, HDDSize = 160, VGASize = 2, Price = 25000, Quantity = 6},
                new PC(){ID = 5, Name = "Variant5", ProcessorType = "AMD", ProcessorFrequency = 3.0, RAMSize = 16, HDDSize = 512, VGASize = 4, Price = 50000, Quantity = 23},
                new PC(){ID = 6, Name = "Variant6", ProcessorType = "AMD", ProcessorFrequency = 3.7, RAMSize = 64, HDDSize = 1024, VGASize = 8, Price = 105000, Quantity = 34},
            };

            Console.WriteLine("Введите тип процессора:");

            string chooseProcessor = Console.ReadLine();

            List<PC> selectedPC1 = listPC
                                   .Where(pc => pc.ProcessorType == "Intel")
                                   .ToList();

            Console.WriteLine($"Все компьютеры с процессором {chooseProcessor}:");

            foreach (var item in selectedPC1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Введите количество оперативной памяти:");

            int chooseRAM = int.Parse(Console.ReadLine());

            List<PC> selectedPC2 = listPC
                                   .Where(pc => pc.RAMSize >= chooseRAM)
                                   .ToList();

            Console.WriteLine($"Все компьютеры с количеством оператиыной памяти не менее {chooseRAM}:");

            foreach (var item in selectedPC2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Список компьютеров, отсортированный по увеличению стоимости:");

            List<PC> selectedPC3 = listPC
                                   .OrderBy(pc => pc.Price)
                                   .ToList();

            foreach (var item in selectedPC3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            var selectedPC4 = listPC
                                .GroupBy(pcGroupped => pcGroupped.ProcessorType)
                                .Select(pcType => new
                                {
                                    Type = pcType.Key,
                                    GrouppedPC = pcType.Select(pcGroupped => pcGroupped)
                                });


            foreach (var group in selectedPC4)
            {
                Console.WriteLine($"Компьюиеры фирмы {group.Type}:");
                foreach (PC pc in group.GrouppedPC)
                {
                    Console.WriteLine(pc.ToString());                   
                }
                Console.WriteLine();
            }
                        
            Console.WriteLine();
            Console.WriteLine();

            //считаем, что нет моделей с одинаковой ценой
            decimal minPrice = listPC.Min(pc => pc.Price);
            decimal maxPrice = listPC.Max(pc => pc.Price);

            Console.WriteLine($"Самый дешевый компьютер: {listPC.FirstOrDefault(a => a.Price == minPrice)}.");

            Console.WriteLine();

            Console.WriteLine($"Самый дорогой компьютер: {listPC.FirstOrDefault(a => a.Price == maxPrice)}.");

            Console.WriteLine();
            Console.WriteLine();

            List<PC> selectedPC5 = listPC
                                   .Where(pc => pc.Quantity >= 30)
                                   .ToList();

            if (selectedPC5.Count > 0)
            {
                Console.WriteLine($"Все модели компьютеров количеством не менее 30:");

                foreach (var item in selectedPC5)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("На складе нет моделей компьютеров количеством от 30 штук.");

            Console.ReadKey();

        }
    }
}
