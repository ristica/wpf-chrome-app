using System.Collections.ObjectModel;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<IUserControl?>? _views;

    #endregion

    #region PROPERTIES

    public ObservableCollection<IUserControl?>? Views
    {
        get => _views;
        private set
        {
            _views = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region METHODS

    public void AddView(string windowIdentifier)
    {
        this.Views ??= [];

        var vm = this._container.Resolve<IUserControlParentViewModel>(windowIdentifier);
        if (vm == null) return;
        this.CurrentUserControl = vm.GetUserControl();
        if (this.CurrentUserControl != null) this.Views.Add(this.CurrentUserControl);
    }

    public void RemoveView(string windowIdentifier)
    {
        if (this.Views == null || !this.Views.Any()) return;

        var found = this.Views.SingleOrDefault(v => v!.ViewModel!.WindowIdentifier.Equals(windowIdentifier));
        if (found == null) return;

        this.Views!.Remove(found);
    }

    #endregion
}