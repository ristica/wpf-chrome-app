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
                return new SolidColorBrush(Color.FromRgb(220,76,100));
            case SnackBarType.Warning:
                return new SolidColorBrush(Color.FromRgb(228,161,27));
            case SnackBarType.Info:
                return new SolidColorBrush(Color.FromRgb(84,180,211));
            case SnackBarType.Success:
                return new SolidColorBrush(Color.FromRgb(20,164,77));
            default:
                return new SolidColorBrush(Color.FromRgb(21, 21, 21));
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}