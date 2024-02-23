using System.Windows.Input;
using Chrome.Models;
using Chrome.ViewModels.Commands.Shell;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _isLanguageInfoVisible;

    #endregion

    #region PROPERTIES

    public List<LanguageInfo>? Cultures { get; set; }

    public bool IsLanguageInfoVisible
    {
        get => _isLanguageInfoVisible;
        set
        {
            _isLanguageInfoVisible = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? OpenLanguagePopupCommand { get; private set; }
    public ICommand? CloseLanguagePopupCommand { get; private set; }
    public ICommand? SetLanguageCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterBottomLanguageBarCommands()
    {
        SetLanguageCommand = new SetLanguageCommand(this);
        OpenLanguagePopupCommand = new OpenLanguagePopupCommand(this);
        CloseLanguagePopupCommand = new CloseLanguagePopupCommand(this);
    }

    private void SetCommonCultures()
    {
        Cultures =
        [
            new LanguageInfo
            {
                CultureId = Constants.CultureTypes.EnglishCultureId,
                ShortName = Constants.CultureTypes.EnglishShortName
            },

            new LanguageInfo
            {
                CultureId = Constants.CultureTypes.DeutschCultureId,
                ShortName = Constants.CultureTypes.DeutschShortName
            }
        ];
    }

    #endregion
}