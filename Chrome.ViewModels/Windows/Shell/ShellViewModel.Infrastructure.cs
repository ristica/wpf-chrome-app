using System.Collections.ObjectModel;
using Chrome.Common.Contracts;
using Localization.WPF;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    private ObservableCollection<IUserControl> _views;

    #region PROPERTIES

    public string CurrentCultureName => LocalizationManager.CurrentCulture.Name;

    public ObservableCollection<IUserControl>? Views
    {
        get => this._views;
        private set
        {
            this._views = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region METHODS

    public void CultureChanged(string cultureName)
    {
        OnPropertyChanged(nameof(CurrentCultureName));
        LoadMenuItems();
    }

    public void OpenView(string windowIdentifier)
    {
        if (this.Views == null) this.Views = new();

        this.CurrentUserControl = _container.Resolve<IUserControlParentViewModel>(windowIdentifier).GetUserControl();
        this.Views.Add(this.CurrentUserControl!);
    }

    #endregion
}