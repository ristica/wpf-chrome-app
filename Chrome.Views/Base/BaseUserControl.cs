using Chrome.Common.Contracts;
using Chrome.Views.Helpers;
using Chrome.Views.Windows.ShellUserControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chrome.Views.Base;

public abstract class BaseUserControl : UserControl
{
    private int _edgeType;

    public IUserControlParentViewModel? ViewModel { get; protected set; }

    protected BaseUserControl()
    {
        Loaded += (s, e) => { VisualTreeHelperExtension.SetViewsArrangement(this); };
    }

    public void OnUserControlActivate()
    {
        VisualTreeHelperExtension.SetViewsArrangement(this);
    }

    public void OnTopBarMouseDown(MouseButtonEventArgs e)
    {
        var offset = e.GetPosition(this);
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

    public void OnMarkerMouseDown(string marker)
    {
        _edgeType = marker switch
        {
            "TL" => (int)EdgeTypes.TopLeft,
            "TR" => (int)EdgeTypes.TopRight,
            "BR" => (int)EdgeTypes.BottomRight,
            "BL" => (int)EdgeTypes.BottomLeft,
            _ => (int)EdgeTypes.TopMove
        };

        SetSizing();
    }

    public void OnUserControlMouseLeave()
    {
        Cursor = Cursors.Arrow;
    }

    private UIElement? GetMainUserControlParent()
    {
        var canvasMain = VisualTreeHelperExtension.FindVisualParent<Canvas>(this);
        var mainContentUSerControl = VisualTreeHelperExtension.FindVisualParent<MainContentUserControl>(canvasMain);
        return mainContentUSerControl;
    }

    private void SetSizing()
    {
        var main = GetMainUserControlParent() as MainContentUserControl;

        main!.IsSizing = true;
        main.SizingEdgeType = _edgeType;
        main.SizingPanel = this;
    }
}