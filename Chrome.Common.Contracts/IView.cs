using System.Windows;

namespace Chrome.Common.Contracts;

public interface IView
{
    IParentViewModel ViewModel { get; }
    void DragMe();
    void OpenMe();
    void CloseMe();
    void MaximizeView();
    void MinimizeView();
    void SetDataContext<T>(T viewModel) where T : IParentViewModel;
    WindowState CurrentWindowState { get; }

    event EventHandler<WindowState> WindowStateChanged;
    event EventHandler WindowLoaded;
}