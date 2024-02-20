using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Chrome.Views.Converters;

public class MenuModelToMenuMarginConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return new Thickness(1, 32, 0, 0);

        var position = value is Point point ? point : default;

        return new Thickness(position.X - 15.00, 32, 0, 0);
        
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}