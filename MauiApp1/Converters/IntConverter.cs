﻿using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace MauiApp1.Converters
{
    internal class IntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is int ival ? ival.ToString() : "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return int.TryParse(value as string, out int result) ? result : 0;
        }
    }
}
