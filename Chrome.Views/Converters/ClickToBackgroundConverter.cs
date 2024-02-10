using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Chrome.Views.Converters;

public class ClickToBackgroundConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var collapsed = new SolidColorBrush(Color.FromRgb(33, 33, 33));
        var expanded = new SolidColorBrush(Color.FromRgb(68, 68, 68));

        if (value == null) return collapsed;

        var currentBrush = value as SolidColorBrush;
        if (currentBrush != null) return collapsed;

        return currentBrush == collapsed ? expanded : collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}