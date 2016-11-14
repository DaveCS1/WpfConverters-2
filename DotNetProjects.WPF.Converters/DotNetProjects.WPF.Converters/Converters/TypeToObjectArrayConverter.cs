﻿using System;
using System.Windows.Data;

namespace DotNetProjects.WPF.Converters.Converters
{
    public class TypeToObjectArrayConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;
            return new object[] {value};            
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }   
    }
}
