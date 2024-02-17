using System.Windows.Input;
using Chrome.Models;
using Chrome.ViewModels.Commands;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    public List<LanguageInfo>? Cultures { get; set; }

    #endregion

    #region COMMANDS

    public ICommand? ToggleLanguagePopupCommand { get; private set; }
    public ICommand? SetLanguageCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterBottomLanguageBarCommands()
    {
        SetLanguageCommand = new SetLanguageCommand(this);
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