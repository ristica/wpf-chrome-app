using System.Collections.ObjectModel;
using Chrome.Models;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<MenuModel>? _favorites;
    private bool _isRightBarExpanded;

    #endregion

    #region PROPERTIES

    public ObservableCollection<MenuModel>? Favorites
    {
        get => _favorites;
        private set
        {
            _favorites = value;
            OnPropertyChanged();
        }
    }

    public bool IsRightBarExpanded
    {
        get => _isRightBarExpanded;
        set
        {
            _isRightBarExpanded = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    #endregion

    #region HELPERS

    private void RegisterRightSideBarCommands()
    {
    }

    #endregion
}