﻿using System.Globalization;

namespace StockExchangeCity.UI.Converters
{
	public class DebugConverter : IValueConverter
	{
		public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			System.Diagnostics.Debug.WriteLine($"[DEBUG] Convert: {value} (Type: {value?.GetType().Name})");
			return value;
		}

		public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			System.Diagnostics.Debug.WriteLine($"[DEBUG] ConvertBack: {value}");
			return value;
		}
	}
}
