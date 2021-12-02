using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    
    public class Building
    {
        protected string Adress { get; private set; }
        protected double Length { get; private set; }
        protected double Width { get; private set; }
        protected double Height { get; private set; }

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine($"Здание расположено по адресу: {Adress}.\nДлина здания: {Length}.\nШирина здания: {Width}.\nВысота здания: {Height}.");
        }
    }
    

    
    public sealed class MultiBuilding : Building
    {
        private double Levels { get; set; }
        public MultiBuilding(string adress, double length, double width, double height, double levels)
            : base(adress, length, width, height)
        {
            Levels = levels;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей в здании: {Levels}.");
        }
    }
    
    
}
