﻿using System;

namespace DotNetProjects.WPF.Converters.Converters
{
    public class WidthConverter : ValueConverter
	{
		public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (double)value / 2;
		}

		public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
