using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF_Task14
{
    public enum ProductCategories : byte
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
