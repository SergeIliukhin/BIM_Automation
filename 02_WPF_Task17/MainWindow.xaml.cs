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
using System.Globalization;

namespace _02_WPF_Task17
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelRed.Content = "Red (" + (Math.Round(sliderRed.Value,0)).ToString() + "):";
        }


        private void sliderGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelGreen.Content = "Green (" + (Math.Round(sliderGreen.Value, 0)).ToString() + "):";
        }

        private void sliderBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelBlue.Content = "Blue (" + (Math.Round(sliderBlue.Value, 0)).ToString() + "):";
        }
    }

}
