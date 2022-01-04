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

namespace _02_WPF_Task04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double USDrateDouble = double.Parse(USDrate.Text);
            double USDsumDouble = double.Parse(USDsum.Text);
            double USDresDouble = Math.Round(USDrateDouble * USDsumDouble, 2, MidpointRounding.AwayFromZero);
            USDresSum.Text = USDresDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double EURrateDouble = double.Parse(EURrate.Text);
            double EURsumDouble = double.Parse(EURsum.Text);
            double EURresDouble = Math.Round(EURrateDouble * EURsumDouble, 2, MidpointRounding.AwayFromZero);
            EURresSum.Text = EURresDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double UAHrateDouble = double.Parse(UAHrate.Text);
            double UAHsumDouble = double.Parse(UAHsum.Text);
            double UAHresDouble = Math.Round(UAHrateDouble * UAHsumDouble, 2, MidpointRounding.AwayFromZero);
            UAHresSum.Text = UAHresDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double AMDrateDouble = double.Parse(AMDrate.Text);
            double AMDsumDouble = double.Parse(AMDsum.Text);
            double AMDresDouble = Math.Round(AMDrateDouble * AMDsumDouble, 2, MidpointRounding.AwayFromZero);
            AMDresSum.Text = AMDresDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {            
            double inchSumDouble = double.Parse(inchSum.Text);
            double inchResDouble = Math.Round(inchSumDouble * 0.0254, 4, MidpointRounding.AwayFromZero);
            inchResSum.Text = inchResDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double ftSumDouble = double.Parse(ftSum.Text);
            double ftResDouble = Math.Round(ftSumDouble * 0.3, 4, MidpointRounding.AwayFromZero);
            ftResSum.Text = ftResDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double milesSumDouble = double.Parse(milesSum.Text);
            double milesDouble = Math.Round(milesSumDouble * 1609.34, 4, MidpointRounding.AwayFromZero);
            milesResSum.Text = milesDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verstSumDouble = double.Parse(verstSum.Text);
            double verstDouble = Math.Round(verstSumDouble * 1066.8, 4, MidpointRounding.AwayFromZero);
            verstResSum.Text = verstDouble.ToString();
        }
    }
}
