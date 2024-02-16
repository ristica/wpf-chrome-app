using System.Windows;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    public string WindowTitle => "CRM - Light";
    public bool CanClose => true;
    public ResizeMode ResizeMode => ResizeMode.CanMinimize;
    public WindowState CurrentWindowState => this._view.CurrentWindowState;

    #endregion

    #region METHODS

    public void OpenView()
    {
        this._view.OpenMe();
    }

    public void MaximizeView()
    {
        this._view.MaximizeView();
        OnPropertyChanged(nameof(CurrentWindowState));
    }

    public void MinimizeView()
    {
        this._view.MinimizeView();
    }

    public void CloseView()
    {
        if (!this.CanClose) return;

        base.Dispose();
        this._view.CloseMe();
    }

    #endregion
}