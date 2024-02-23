using Chrome.ViewModels.Commands;
using System.Windows.Input;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private string _currentUser;
    private bool _isBottomBarExpanded;

    #endregion

    #region PROPERTIES

    public string CurrentUser
    {
        get => _currentUser;
        set
        {
            _currentUser = value;
            OnPropertyChanged();
        }
    }

    public bool IsBottomBarExpanded
    {
        get => _isBottomBarExpanded;
        set
        {
            _isBottomBarExpanded = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleBottomBarCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterBottomBarCommands()
    {
        ToggleBottomBarCommand = new ToggleBottomBarCommand(this);
    }

    #endregion
}