using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Chrome.Models;

namespace Chrome.Views.Converters;

public class NotNullToVisibilityConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not List<MenuModel> list) return Visibility.Collapsed;

        return list.Count > 0 ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}