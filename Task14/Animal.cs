using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }


        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();
        
        public void ShowInfo()
        {
            Console.Write($"Название животного: {Name}, его голос: ");
            Say();
        }
    }

    public class Cat : Animal
    {
        public override string Name { get; set; }       

        public Cat(string name)
            : base(name)
        {
            
        }

        public override void Say()
        {
            Console.Write("Мяу.");
        }
    }

    public class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string name)
            : base(name)
        {

        }

        public override void Say()
        {
            Console.Write("Гав.");
        }
    }

}
