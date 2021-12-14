using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            //защиту от неправильного ввода суммы на счете не предусматриваем

            Console.WriteLine("Введите данные счета в формате Номер/Сумма/ФИО.");

            string data = Console.ReadLine();

            string[] dataSplitted = data.Split('/');
            
           
            int numberID;           
           
            bool parsedID = int.TryParse(dataSplitted[0], out numberID);

            if (parsedID == true)
            {
                Account<int> person = new Account<int>(numberID, decimal.Parse(dataSplitted[1]), dataSplitted[2]);
                person.PrintDetails(person.ID, person.Sum, person.Name);
                Console.WriteLine("Введите новую сумму на счете:");
                decimal newSum = decimal.Parse(Console.ReadLine());
                person.ChangeSum(newSum, person.Name);
            }
            else
            {
                Account<string> person = new Account<string>(dataSplitted[0], decimal.Parse(dataSplitted[1]), dataSplitted[2]);
                person.PrintDetails(person.ID, person.Sum, person.Name);
                Console.WriteLine("Введите новую сумму на счете:");
                decimal newSum = decimal.Parse(Console.ReadLine());
                person.ChangeSum(newSum, person.Name);
            }

            Console.ReadKey();            

        }
    }
}
