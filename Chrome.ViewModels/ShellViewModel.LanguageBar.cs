using Chrome.ViewModels.Commands;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _isLanguagePopupOpen;

    #endregion

    #region PROPERTIES

    public bool IsLanguagePopupOpen
    {
        get => this._isLanguagePopupOpen;
        set
        {
            this._isLanguagePopupOpen = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleLanguagePopupCommand { get; private set; }
    public ICommand? SetLanguageCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterBottomLanguageBarCommands()
    {
        ToggleLanguagePopupCommand = new ToggleLanguagePopupCommand(this);
        SetLanguageCommand = new SetLanguageCommand(this);
    }

    #endregion
}