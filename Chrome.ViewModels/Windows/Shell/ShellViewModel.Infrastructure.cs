using System.Globalization;
using System.Windows;
using Chrome.Common.Contracts;
using Chrome.ViewModels.Contracts.Uebersicht;
using Localization.WPF;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
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

    public void OpenView(string windowIdentifier)
    {
        this.CurrentUserControl = this._container.Resolve<IUserControlParentViewModel>(windowIdentifier).GetUserControl();
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