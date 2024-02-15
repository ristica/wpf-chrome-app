using Chrome.Models;
using Chrome.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _isBottomBarVisible;
    private ObservableCollection<CustomerUiModel>? _customers;
    private bool _isLeftBarExpanded;

    #endregion

    #region PROPERTIES

    public bool IsLeftBarExpanded
    {
        get => this._isLeftBarExpanded;
        set
        {
            this._isLeftBarExpanded = value;
            OnPropertyChanged();
        }
    }

    public bool IsBottomBarVisible
    {
        get => this._isBottomBarVisible;
        set
        {
            this._isBottomBarVisible = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<CustomerUiModel>? Customers
    {
        get => this._customers;
        set
        {
            this._customers = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleBottomBarCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterLeftSideBarCommands()
    {
        ToggleBottomBarCommand = new ToggleBottomBarCommand(this);
    }

    private void SetTestCustomers()
    {
        this.Customers = new ObservableCollection<CustomerUiModel>(Helpers.CustomerGenerator.Generate());
        this.IsLeftBarExpanded = this.Customers.Any();
    }

    #endregion
}