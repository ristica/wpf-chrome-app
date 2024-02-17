using System.Windows;

namespace Chrome.Common.Contracts;

public interface IParentViewModel
{
    string WindowTitle { get; }
    bool CanClose { get; }
    ResizeMode ResizeMode { get; }
    WindowState CurrentWindowState { get; }

    IView GetView();

    void MaximizeView();
    void MinimizeView();
    void CloseView();
    void DragWindow();
}