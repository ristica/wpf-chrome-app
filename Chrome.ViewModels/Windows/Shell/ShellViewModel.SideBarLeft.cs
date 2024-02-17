using System.Collections.ObjectModel;
using System.Windows.Input;
using Chrome.Models;
using Chrome.ViewModels.Commands;

namespace Chrome.ViewModels.Windows.Shell;

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
        get => _isLeftBarExpanded;
        set
        {
            _isLeftBarExpanded = value;
            OnPropertyChanged();
        }
    }

    public bool IsBottomBarVisible
    {
        get => _isBottomBarVisible;
        set
        {
            _isBottomBarVisible = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<CustomerUiModel>? Customers
    {
        get => _customers;
        set
        {
            _customers = value;
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
        Customers = new ObservableCollection<CustomerUiModel>(Helpers.CustomerGenerator.Generate());
        IsLeftBarExpanded = Customers.Any();
    }

    #endregion
}