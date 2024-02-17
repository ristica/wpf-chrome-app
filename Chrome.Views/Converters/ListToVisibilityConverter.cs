using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Chrome.Views.Converters;

public class ListToVisibilityConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not IEnumerable<object> list) return Visibility.Collapsed;

        return list.Any();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}