using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.CustomControls
{
    public class NotEqualsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = (double)value;
            double par = System.Convert.ToDouble(parameter);

            if (val == par) return false;
            else return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
