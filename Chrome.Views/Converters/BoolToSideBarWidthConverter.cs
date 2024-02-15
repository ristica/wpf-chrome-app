using System.Globalization;
using System.Windows.Data;

namespace Chrome.Views.Converters;

public class BoolToSideBarWidthConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null) return 0M;
        return (bool)value ? 200M : 90M;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}