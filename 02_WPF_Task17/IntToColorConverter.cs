using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace _02_WPF_Task17
{
    public class IntToColorConverter : IMultiValueConverter
    {
        #region IMultiValueConverter Members
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new SolidColorBrush(Color.FromRgb(
                (byte)(double)values[0],
                (byte)(double)values[1],
                (byte)(double)values[2]));
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}