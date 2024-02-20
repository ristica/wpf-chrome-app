﻿using System.Windows.Input;
using Chrome.Models;
using Chrome.ViewModels.Commands;

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
        get => this._isLanguageInfoVisible;
        set
        {
            this._isLanguageInfoVisible = value;
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
        SetLanguageCommand = new SetLanguageCommand(this);
        ToggleLanguagePopupCommand = new ToggleLanguagePopupCommand(this);
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