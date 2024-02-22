using System.Windows;
using System.Windows.Media;

namespace Chrome.Views.Helpers;

public static class VisualTreeHelperExtension
{
    public static T? FindVisualParent<T>(DependencyObject? child) where T : DependencyObject
    {
        if (child == null) return null;

        var parentObj = VisualTreeHelper.GetParent(child);

        return parentObj switch
        {
            null => null,
            T parent => parent,
            _ => FindVisualParent<T>(parentObj)
        };
    }
}