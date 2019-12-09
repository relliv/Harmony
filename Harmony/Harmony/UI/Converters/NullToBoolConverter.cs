﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Harmony.UI.Converters
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class NullToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
