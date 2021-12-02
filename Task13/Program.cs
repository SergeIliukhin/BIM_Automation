using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building bld = new Building("Адрес", 100, 50, 25);

            bld.Print();

            Console.WriteLine();

            MultiBuilding mBld = new MultiBuilding("Адрес", 100, 50, 25, 8);

            mBld.Print();

            Console.ReadKey();
        }
    }

}
