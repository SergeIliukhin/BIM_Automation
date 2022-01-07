using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult resultExit = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo);
            switch (resultExit)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as string).ToString();
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as string).ToString();
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

        /* Вариант кода с обработчиками событий

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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog()==true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
                
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }        

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
        */
        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void CloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult resultExit = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo);
            switch (resultExit)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
}
