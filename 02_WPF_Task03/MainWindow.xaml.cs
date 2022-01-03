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

namespace _02_WPF_Task03
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            

            if (textBox != null)
            {
                textBox.FontSize = double.Parse(fontSize);
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (textBox != null && (textBox.FontWeight != FontWeights.Bold))
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else if (textBox != null && (textBox.FontWeight == FontWeights.Bold))
            {
                textBox.FontWeight = FontWeights.Regular;
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (textBox != null && (textBox.FontStyle != FontStyles.Italic))
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else if (textBox != null && (textBox.FontStyle == FontStyles.Italic))
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (textBox != null && (textBox.TextDecorations != TextDecorations.Underline))
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else if (textBox != null && (textBox.TextDecorations == TextDecorations.Underline))
            {
                textBox.TextDecorations = null;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }            
        }
    }
}
