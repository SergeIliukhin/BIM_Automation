using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Кошка");           
            cat.ShowInfo();

            Console.WriteLine();
            Console.WriteLine();

            Animal dog = new Dog("Собака");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
