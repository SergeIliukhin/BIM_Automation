using System;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;



namespace Task16
{
    class Program
    {
        public static bool WriteIndented { get; private set; }

        static void Main(string[] args)
        {
            //В данном случае не предусматриваем защиту от неверного ввода
            Console.WriteLine("Последовательно введите данные о пяти товарах, перечислив в каждом через запятую без пробелов информацию в формате \"Серийный номер,Название,Цена\".");


            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = false
            };

            Product[] allProductsArray = new Product[5];

            int count = 0;

            while (count < 5)
            {
                string productString = Console.ReadLine();
                string[] productArray = productString.Split(',');
                int productID = int.Parse(productArray[0]);
                string productName = productArray[1];
                decimal productPrice = decimal.Parse(productArray[2]);
                Product item = new Product(productID, productName, productPrice);
                allProductsArray[count] = item;

                count += 1;
            }

            string path = @"G:\BIM_Automation\Products.json";

            /*
            if (!File.Exists(path))
                File.Create(path);
            */

            for (int i = 0; i < allProductsArray.Length; i++)
            {
                string product = JsonSerializer.Serialize(allProductsArray[i], options);
                using (StreamWriter sw = new StreamWriter(path, true))
                    sw.WriteLine(product);
            }

            string fileData;

            using (StreamReader sr = new StreamReader(path))
            {
                fileData = sr.ReadToEnd();
            }

            string[] fileDataText = fileData.Split('\n');

            decimal[] productPricesFromFile = new decimal[5];
            string[] productNamesFromFile = new string[5];


            for (int i = 0; i < fileDataText.Length - 1; i++)
            {
                Product product = JsonSerializer.Deserialize<Product>(fileDataText[i].Trim());
                productPricesFromFile[i] = product.ProductPrice;
                productNamesFromFile[i] = product.ProductName;
            }

            decimal maxPrice = productPricesFromFile.Max();

            int indexOfMaxPrice = Array.IndexOf(productPricesFromFile, maxPrice);

            string productWithMaxPrice = productNamesFromFile[indexOfMaxPrice];

            Console.WriteLine($"Самый дорогой товар в списке: {productWithMaxPrice} стоимостью {maxPrice}.");

            Console.ReadKey();

        }
    }
}
