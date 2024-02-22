using Chrome.Views.Helpers;
using Chrome.Views.Windows.ShellUserControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chrome.Views.Base
{
    public abstract class BaseUserControl : UserControl
    {
        private int _edgeType;

        protected IInputElement? TopBar { get; set; }

        protected abstract void SetTopBar();

        protected void TopBarOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var offset = e.GetPosition(this.TopBar);
            var offsetX = offset.X;
            var offsetY = offset.Y;

            var main = this.GetMainUserControlParent() as MainContentUserControl;

            main.SetViewsArrangements(this);

            main!.IsSizing = true;
            main.SizingEdgeType = 0;
            main.SizingPanel = this;
            main.SizingOffsetX = offsetX;
            main.SizingOffsetY = offsetY;
        }

        protected void MarkerOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is not Border marker) return;

            this._edgeType = marker.Name switch
            {
                "MarkerLeftTop" => (int)EdgeTypes.TopLeft,
                "MarkerRightTop" => (int)EdgeTypes.TopRight,
                "MarkerRightBottom" => (int)EdgeTypes.BottomRight,
                "MarkerLeftBottom" => (int)EdgeTypes.BottomLeft,
                _ => (int)EdgeTypes.TopMove
            };

            SetSizing(sender, e);
        }

        protected void MarkerOnMouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private UIElement? GetMainUserControlParent()
        {
            var canvasMain = VisualTreeHelperExtension.FindVisualParent<Canvas>(this);
            var mainContentUSerControl = VisualTreeHelperExtension.FindVisualParent<MainContentUserControl>(canvasMain);
            return mainContentUSerControl;
        }

        private void SetSizing(object sender, MouseButtonEventArgs e)
        {
            var main = this.GetMainUserControlParent() as MainContentUserControl;

            main!.IsSizing = true;
            main.SizingEdgeType = _edgeType;
            main.SizingPanel = this;
        }
    }
}
