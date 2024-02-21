using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Chrome.Views.Windows.ShellUserControls
{
    public partial class MainContentUserControl : UserControl
    {
        public MainContentUserControl()
        {
            InitializeComponent();
        }

        #region RESIZING

        // The part of the rectangle the mouse is over.
        private enum HitType
        {
            None, Body, UL, UR, LR, LL, L, R, T, B
        };

        // True if a drag is in progress.
        private bool _dragInProgress;

        // The drag's last point.
        private Point _lastPoint;

        // The part of the rectangle under the mouse.
        HitType _mouseHitType = HitType.None;

        // Return a HitType value to indicate what is at the point.
        private HitType SetHitType(Border rect, Point point)
        {
            var left = Canvas.GetLeft(rectangle1);
            var top = Canvas.GetTop(rectangle1);
            var right = left + rectangle1.Width;
            var bottom = top + rectangle1.Height;

            if (point.X < left) return HitType.None;
            if (point.X > right) return HitType.None;
            if (point.Y < top) return HitType.None;
            if (point.Y > bottom) return HitType.None;

            const double gap = 10;
            if (point.X - left < gap)
            {
                // Left edge.
                if (point.Y - top < gap) return HitType.UL;
                if (bottom - point.Y < gap) return HitType.LL;
                return HitType.L;
            }
            if (right - point.X < gap)
            {
                // Right edge.
                if (point.Y - top < gap) return HitType.UR;
                if (bottom - point.Y < gap) return HitType.LR;
                return HitType.R;
            }
            if (point.Y - top < gap) return HitType.T;
            if (bottom - point.Y < gap) return HitType.B;
            return HitType.Body;
        }

        // Set a mouse cursor appropriate for the current hit type.
        private void SetMouseCursor()
        {
            // See what cursor we should display.
            var desiredCursor = Cursors.Arrow;
            switch (_mouseHitType)
            {
                case HitType.None:
                    desiredCursor = Cursors.Arrow;
                    break;
                case HitType.Body:
                    desiredCursor = Cursors.ScrollAll;
                    break;
                case HitType.UL:
                case HitType.LR:
                    desiredCursor = Cursors.SizeNWSE;
                    break;
                case HitType.LL:
                case HitType.UR:
                    desiredCursor = Cursors.SizeNESW;
                    break;
                case HitType.T:
                case HitType.B:
                    desiredCursor = Cursors.SizeNS;
                    break;
                case HitType.L:
                case HitType.R:
                    desiredCursor = Cursors.SizeWE;
                    break;
            }

            // Display the desired cursor.
            if (Cursor != desiredCursor) Cursor = desiredCursor;
        }

        // Start dragging.
        private void UserControlMouseDown(object sender, MouseButtonEventArgs e)
        {
            _mouseHitType = SetHitType(rectangle1, Mouse.GetPosition(canvas1));
            SetMouseCursor();
            if (_mouseHitType == HitType.None) return;

            _lastPoint = Mouse.GetPosition(canvas1);
            _dragInProgress = true;
        }

        // If a drag is in progress, continue the drag.
        // Otherwise display the correct cursor.
        private void UserControlMouseMove(object sender, MouseEventArgs e)
        {
            
            if (!_dragInProgress)
            {
                _mouseHitType = SetHitType(rectangle1, Mouse.GetPosition(canvas1));
                SetMouseCursor();
            }
            else
            {
                var point = Mouse.GetPosition(canvas1);

                // See how much the mouse has moved.
                var offsetX = point.X - _lastPoint.X;
                var offsetY = point.Y - _lastPoint.Y;

                // Get the rectangle's current position.
                var newX = Canvas.GetLeft(rectangle1);
                var newWidth = rectangle1.Width;
                var newY = Canvas.GetTop(rectangle1);
                var newHeight = rectangle1.Height;

                if (newX <= 2) newX = 2;
                if (newY <= 1) newY = 1;

                var right = newX + newWidth;
                var bottom = newY + newHeight;

                if (right >= canvas1.ActualWidth) newX -= 1;
                if (bottom >= canvas1.ActualHeight) newY -= 1;

                Debug.Print($"L: {newX} - T: {newY} - R: {right} - B: {bottom}");

                // Update the rectangle.
                switch (_mouseHitType)
                {
                    case HitType.Body:
                        newX += offsetX;
                        newY += offsetY;
                        break;
                    case HitType.UL:
                        newX += offsetX;
                        newY += offsetY;
                        newWidth -= offsetX;
                        newHeight -= offsetY;
                        break;
                    case HitType.UR:
                        newY += offsetY;
                        newWidth += offsetX;
                        newHeight -= offsetY;
                        break;
                    case HitType.LR:
                        newWidth += offsetX;
                        newHeight += offsetY;
                        break;
                    case HitType.LL:
                        newX += offsetX;
                        newWidth -= offsetX;
                        newHeight += offsetY;
                        break;
                    case HitType.L:
                        newX += offsetX;
                        newWidth -= offsetX;
                        break;
                    case HitType.R:
                        newWidth += offsetX;
                        break;
                    case HitType.B:
                        newHeight += offsetY;
                        break;
                    case HitType.T:
                        newY += offsetY;
                        newHeight -= offsetY;
                        break;
                }

                // Don't use negative width or height.
                if (!(newWidth > 0) || !(newHeight > 0)) return;

                // Update the rectangle.
                Canvas.SetLeft(rectangle1, newX);
                Canvas.SetTop(rectangle1, newY);
                rectangle1.Width = newWidth;
                rectangle1.Height = newHeight;

                // Save the mouse's new location.
                _lastPoint = point;
            }
        }

        // Stop dragging.
        private void UserControlMouseUp(object sender, MouseButtonEventArgs e)
        {
            _dragInProgress = false;
        }

        #endregion
    }
}
