using Chrome.ViewModels.Commands;
using System.Windows.Input;
using Chrome.Models;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    public List<LanguageInfo> Cultures { get; set; }

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
        this.Cultures =
        [
            new()
            {
                CultureId = Constants.CultureTypes.EnglishCultureId,
                ShortName = Constants.CultureTypes.EnglishShortName
            },

            new()
            {
                CultureId = Constants.CultureTypes.DeutschCultureId,
                ShortName = Constants.CultureTypes.DeutschShortName
            }
        ];
    }

    #endregion
}