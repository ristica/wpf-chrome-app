using Chrome.Views.Helpers;
using Chrome.Views.Windows.ShellUserControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chrome.Views.Base;

public abstract class BaseUserControl : UserControl
{
    private int _edgeType;

    protected IInputElement? TopBar { get; set; }

    protected BaseUserControl()
    {
        this.Loaded += (s, e) =>
        {
            VisualTreeHelperExtension.SetViewsArrangement(this);
        };
    }

    protected abstract void SetTopBar();

    protected void OnUserControlActivated(
        object sender, 
        MouseButtonEventArgs e)
    {
        VisualTreeHelperExtension.SetViewsArrangement(this);
    }

    protected void TopBarOnMouseDown(
        object sender,
        MouseButtonEventArgs e)
    {
        var offset = e.GetPosition(TopBar);
        var offsetX = offset.X;
        var offsetY = offset.Y;

        var main = GetMainUserControlParent() as MainContentUserControl;

        VisualTreeHelperExtension.SetViewsArrangement(this);

        main!.IsSizing = true;
        main.SizingEdgeType = 0;
        main.SizingPanel = this;
        main.SizingOffsetX = offsetX;
        main.SizingOffsetY = offsetY;
    }

    protected void MarkerOnMouseDown(
        object sender,
        MouseButtonEventArgs e)
    {
        if (sender is not Border marker) return;

        _edgeType = marker.Name switch
        {
            "MarkerLeftTop" => (int)EdgeTypes.TopLeft,
            "MarkerRightTop" => (int)EdgeTypes.TopRight,
            "MarkerRightBottom" => (int)EdgeTypes.BottomRight,
            "MarkerLeftBottom" => (int)EdgeTypes.BottomLeft,
            _ => (int)EdgeTypes.TopMove
        };

        SetSizing(sender, e);
    }

    protected void MarkerOnMouseLeave(
        object sender,
        MouseEventArgs e)
    {
        Cursor = Cursors.Arrow;
    }

    private UIElement? GetMainUserControlParent()
    {
        var canvasMain = VisualTreeHelperExtension.FindVisualParent<Canvas>(this);
        var mainContentUSerControl = VisualTreeHelperExtension.FindVisualParent<MainContentUserControl>(canvasMain);
        return mainContentUSerControl;
    }

    private void SetSizing(
        object sender,
        MouseButtonEventArgs e)
    {
        var main = GetMainUserControlParent() as MainContentUserControl;

        main!.IsSizing = true;
        main.SizingEdgeType = _edgeType;
        main.SizingPanel = this;
    }
}