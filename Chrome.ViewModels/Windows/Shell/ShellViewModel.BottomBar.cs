﻿namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private string _currentUser;

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

    #endregion

    #region HELPERS

    private void RegisterBottomBarCommands()
    {
    }

    #endregion
}