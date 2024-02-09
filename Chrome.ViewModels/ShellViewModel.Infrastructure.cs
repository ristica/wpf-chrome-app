using System.Windows;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region PROPERTIES

    public bool CanClose { get; private set; } = true;
    public ResizeMode ResizeMode { get; private set; } = ResizeMode.CanResize;

    #endregion

    #region METHODS

    public void OpenView()
    {
        _view.OpenMe();
    }

    public void MaximizeView()
    {
        _view.MaximizeView();
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