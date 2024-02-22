using Chrome.Common.Contracts;
using Localization.WPF;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region PROPERTIES

    public string CurrentCultureName => LocalizationManager.CurrentCulture.Name;

    #endregion

    #region METHODS

    public void CultureChanged(string cultureName)
    {
        OnPropertyChanged(nameof(CurrentCultureName));
        LoadMenuItems();
    }

    public void OpenView(string windowIdentifier)
    {
        CurrentUserControl = _container.Resolve<IUserControlParentViewModel>(windowIdentifier).GetUserControl();
    }

    #endregion
}