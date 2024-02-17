using System.Globalization;
using System.Windows;
using Localization.WPF;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    public string CurrentCultureName => LocalizationManager.CurrentCulture.Name;
    public string WindowTitle => "CRM - Light";
    public bool CanClose => true;
    public ResizeMode ResizeMode => ResizeMode.CanMinimize;
    public WindowState CurrentWindowState => _view.CurrentWindowState;

    #endregion

    #region METHODS

    public void CultureChanged(string cultureName)
    {
        OnPropertyChanged(nameof(CurrentCultureName));
        this.SetCarouselItems();
    }

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
        if (!CanClose) return;

        Dispose();
        _view.CloseMe();
    }

    public void DragWindow()
    {
        _view.DragMe();
    }

    #endregion
}