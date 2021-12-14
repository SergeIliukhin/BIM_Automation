using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    public class Account<T>
    {
        public T ID { get; private set; }
        public decimal Sum { get; private set; }
        public string Name { get; private set; }

        public Account(T id, decimal sum, string name)
        {
            ID = id;
            Sum = sum;
            Name = name;
        }

       public void PrintDetails<T>(T id, decimal sum, string name)
        {
            
            Console.WriteLine($"Данные счета пользователя {name} -  ID: {id}, сумма на счету: {sum}.");
        }

        public void ChangeSum(decimal sum, string name)
        {
            Sum = sum;

            Console.WriteLine($"Новая сумма на счету пользователя {name}: {sum}.");
        }
    }
}
