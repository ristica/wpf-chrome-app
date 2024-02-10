using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Chrome.Views.Converters;

public class WindowStateToVisibilityConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null) return Visibility.Collapsed;

        var mode = (WindowState)value;

        return mode == WindowState.Maximized ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}