using Chrome.ViewModels.Commands;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _isBottomBarVisible;

    #endregion
    
    #region PROPERTIES

    public bool IsBottomBarVisible
    {
        get => this._isBottomBarVisible;
        set
        {
            this._isBottomBarVisible = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleBottomBarCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterSideBarCommands()
    {
        ToggleBottomBarCommand = new ToggleBottomBarCommand(this);
    }

    #endregion
}