using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace MauiApp1.Converters
{
    public class InverseBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !bool.TryParse(value as string, out bool res) || !res;
        }
    }
}
