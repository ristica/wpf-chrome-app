using Chrome.Common.Contracts;
using System.Windows;

namespace Chrome.Views.Base;

public abstract class BaseView : Window
{
    #region FIELDS

    

    #endregion

    #region PROPERTIES

    public IParentViewModel ViewModel { get; protected set; } = null!;

    #endregion

    #region C-TOR

    protected BaseView()
    {
        Loaded += BaseWindowLoaded;
    }

    #endregion

    #region METHODS

    protected virtual void BaseWindowLoaded(object sender, RoutedEventArgs e)
    {

    }

    public void OpenMe()
    {
        Show();
    }

    public void CloseMe()
    {
        Close();
    }

    public void MaximizeView()
    {
        ToggleWindowState();
    }

    public void MinimizeView()
    {
        WindowState = WindowState.Minimized;
    }

    public void DragMe()
    {
        DragMove();
    }

    public void SetDataContext<T>(T viewModel) where T : IParentViewModel
    {
        ViewModel = viewModel;
    }

    protected void ToggleWindowState()
    {
        WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    #endregion
}