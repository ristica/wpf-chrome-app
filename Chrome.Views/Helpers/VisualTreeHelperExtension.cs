using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chrome.Views.Helpers;

public static class VisualTreeHelperExtension
{
    public static T? FindVisualParent<T>(DependencyObject? child)
        where T : DependencyObject
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

    public static void SetViewsArrangement(
        UserControl uc)
    {
        if (Panel.GetZIndex(uc!) == 1000) return;

        var canvas = FindVisualParent<Canvas>(uc);
        if (canvas == null) return;

        for (var i = 0; i < canvas.Children.Count; i++)
        {
            var child = canvas.Children[i];

            if (child == uc) continue;

            var currentIndex = Panel.GetZIndex(child);
            if (currentIndex == 101) continue;

            Panel.SetZIndex(child, currentIndex - 1);
        }

        uc.Tag = 1000;
        Panel.SetZIndex(uc, 1000);
    }
}