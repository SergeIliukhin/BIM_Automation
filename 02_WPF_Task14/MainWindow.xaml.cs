using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_WPF_Task14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Молоко",
                Price = 75,
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Стиральная машина",
                Price = 25000,
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                Name = "Йогурт",
                Price = 35,
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 60000,
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
