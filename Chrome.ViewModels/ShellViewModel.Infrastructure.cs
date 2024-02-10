using System.Windows;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private WindowState _currentWindowState;

    #endregion

    #region PROPERTIES

    public bool CanClose { get; private set; } = true;
    public ResizeMode ResizeMode { get; private set; } = ResizeMode.CanResize;
    public WindowState CurrentWindowState => this._view.CurrentWindowState;

    #endregion

    #region METHODS

    public void OpenView()
    {
        _view.OpenMe();
    }

    public void MaximizeView()
    {
        _view.MaximizeView();
        OnPropertyChanged(nameof(CurrentWindowState));
    }

    public void MinimizeView()
    {
        _view.MinimizeView();
    }

    public void CloseView()
    {
        if (CanClose) _view.CloseMe();
    }

    #endregion
}