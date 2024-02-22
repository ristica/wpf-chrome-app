using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Chrome.Views.Helpers;
using MaterialDesignThemes.Wpf;

namespace Chrome.Views.Windows.ShellUserControls;

public partial class MainContentUserControl : UserControl
{
    public MainContentUserControl()
    {
        InitializeComponent();
    }

    #region WINDOW RESIZING, MOVING ARROUND

    public bool IsSizing;
    public int SizingEdgeType;
    public double SizingOffsetX;
    public double SizingOffsetY;
    public UserControl? SizingPanel;

    private void CanvasMainOnMouseUp(object sender, MouseButtonEventArgs e)
    {
        if (!IsSizing) return;

        IsSizing = false;

        SizingEdgeType = -1;
        SizingOffsetX = 0;
        SizingOffsetY = 0;
        SizingPanel = null;
    }

    private void CanvasMainOnMouseMove(object sender, MouseEventArgs e)
    {
        if (IsSizing) SetSizing(sender, e);
    }

    private void SetSizing(object sender, MouseEventArgs e)
    {
        if (!IsSizing) return;

        if (SizingEdgeType < 0) return;
        if (SizingPanel == null) return;

        if (e.LeftButton != MouseButtonState.Pressed)
        {
            IsSizing = false;
        }
        else
        {
            var mousePoint = e.GetPosition(this);
            var mouseX = mousePoint.X;
            var mouseY = mousePoint.Y;

            var position = TranslatePoint(new Point(0, 0), SizingPanel);
            var posX = -position.X;
            var posY = -position.Y;

            var diffX = posX - mouseX;
            var diffY = posY - mouseY;

            if (SizingEdgeType == (int)EdgeTypes.TopMove)
            {
                var newLeft = mouseX - SizingOffsetX;
                var newTop = mouseY - SizingOffsetY;

                var newRight = newLeft + SizingPanel.ActualWidth;
                var newBottom = newTop + SizingPanel.ActualHeight;

                // right / bottom
                var maxWidth = this.ActualWidth - 1;
                var maxHeight = this.ActualHeight - 1;

                if (newRight <= maxWidth)
                {
                    // left
                    if (newLeft > 0) Canvas.SetLeft(SizingPanel, newLeft);

                    if (newBottom <= maxHeight)
                    {
                        // top
                        if (newTop > 0) Canvas.SetTop(SizingPanel, newTop);
                    }
                }
                else if (newBottom <= maxHeight)
                {
                    // top
                    if (newTop > 0) Canvas.SetTop(SizingPanel, newTop);

                    if (newRight <= maxWidth)
                    {
                        // left
                        if (newLeft > 0) Canvas.SetLeft(SizingPanel, newLeft);
                    }
                }
                else
                {
                    Debug.Print($"T: {newTop} - L: {newLeft} - R: {newRight} - B: {newBottom}\t *** W: {maxWidth} - H: {maxHeight}");   
                }
            }
            else
            {
                if (SizingEdgeType == (int)EdgeTypes.TopLeft ||
                    SizingEdgeType == (int)EdgeTypes.BottomLeft)
                {
                    var newLeft = mouseX;
                    var newWidth = SizingPanel.ActualWidth + diffX;

                    if (newLeft > 0) Canvas.SetLeft(SizingPanel, newLeft);
                    if (newWidth > 0) SizingPanel.Width = newWidth;
                }

                if (SizingEdgeType == (int)EdgeTypes.TopLeft ||
                    SizingEdgeType == (int)EdgeTypes.TopRight)
                {
                    var newTop = mouseY;
                    var newHeight = SizingPanel.ActualHeight + diffY;

                    if (newTop > 0) Canvas.SetTop(SizingPanel, newTop);
                    if (newHeight > 0) SizingPanel.Height = newHeight;
                }

                if (SizingEdgeType == (int)EdgeTypes.TopRight ||
                    SizingEdgeType == (int)EdgeTypes.BottomRight)
                {
                    var newWidth = mouseX - posX;

                    if (newWidth > 0) SizingPanel.Width = newWidth;
                }

                if (SizingEdgeType == (int)EdgeTypes.BottomLeft ||
                    SizingEdgeType == (int)EdgeTypes.BottomRight)
                {
                    var newHeight = mouseY - posY;

                    if (newHeight > 0) SizingPanel.Height = newHeight;
                }
            }
        }
    }

    public void SetViewsArrangements(UserControl uc)
    {
        if (Panel.GetZIndex(uc!) == 1000) return;

        var canvas = VisualTreeHelperExtension.FindVisualParent<Canvas>(uc);
        if (canvas == null) return;

        for (var i = 0; i < canvas.Children.Count; i++)
        {
            if (canvas.Children[i] == uc) continue;
            Panel.SetZIndex(canvas.Children[i], i+100);
        }

        Panel.SetZIndex(uc, 1000);
    }

    #endregion
}