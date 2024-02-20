using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Chrome.Views.Converters;

public class MenuModelToBorderWidthConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return new Thickness(1, 32, 0, 0);

        return new Thickness((double)value - 1.00, 0, 0, 0);
        
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}