using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Chrome.Constants;

namespace Chrome.Views.Converters;

public class SnackBarTypeToBackgroundBrush : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null) return new SolidColorBrush(Color.FromRgb(21, 21, 21));
        switch ((SnackBarType)value)
        {
            case SnackBarType.Error:
                return new SolidColorBrush(Colors.Maroon);
            case SnackBarType.Warning:
                return new SolidColorBrush(Colors.DarkOrange);
            case SnackBarType.Info:
                return new SolidColorBrush(Colors.DodgerBlue);
            case SnackBarType.Success:
                return new SolidColorBrush(Colors.DarkGreen);
            default:
                return new SolidColorBrush(Color.FromRgb(21, 21, 21));
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}