using Chrome.Models;
using Chrome.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<MenuModel>? _favorites;
    private bool _isRightBarExpanded;

    #endregion

    #region PROPERTIES

    public ObservableCollection<MenuModel>? Favorites
    {
        get => this._favorites;
        private set
        {
            this._favorites = value;
            OnPropertyChanged();
        }
    }

    public bool IsRightBarExpanded
    {
        get => this._isRightBarExpanded;
        set
        {
            this._isRightBarExpanded = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleRightBarCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterRightSideBarCommands()
    {
        this.ToggleRightBarCommand = new ToggleRightBarCommand(this);
    }

    #endregion
}