using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов угла:");
            int gradus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение минут угла:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение секунд угла:");
            int sec = int.Parse(Console.ReadLine());

            Degrees deg = new Degrees(gradus, min, sec);
            
            deg.ToRadiasns();                            

            Console.ReadKey();
        }
    }

    class Degrees
    {
        private int gradus;
        private int min;
        private int sec;

        private bool gradToCalc = true;
        private bool minToCalc = true;
        private bool secToCalc = true;


        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value >= 0 && value <= 360)
                    gradus = value;
                else if (value > 360)
                {                    
                    gradus = value % 360;
                }
                else
                {
                    Console.WriteLine("Вводимое значение градусов не может быть отрицательным.");
                    gradToCalc = false;
                }
                    
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    min = value;
                else
                {
                    Console.WriteLine("Вводимое значение минут должно лежать в диапазоне от 0 до 60.");
                    minToCalc = false;
                }                    
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    sec = value;
                else
                {
                    Console.WriteLine("Вводимое значение секунд должно лежать в диапазоне от 0 до 60.");
                    secToCalc = false;
                }                    
            }
        }

        public Degrees(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadiasns()
        {
            double resultRadians = 0;
            if (gradToCalc && minToCalc && secToCalc)
            {
                double radFromDeg = (double)gradus * Math.PI / 180;
                double radFronMin = (double)min * Math.PI / (180 * 60);
                double radFronSec = (double)sec * Math.PI / (180 * 60 * 60);
                resultRadians = Math.Round(radFromDeg + radFronMin + radFronSec, 5, MidpointRounding.AwayFromZero);
                Console.WriteLine($"Введенный вами угол в градучах в пересчете в радианы составляет: {resultRadians}");
            }
            else
                Console.WriteLine("Угол не может быть пересчитан в радианы.");
        }
    }


}
