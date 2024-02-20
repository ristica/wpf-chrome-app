using System.Collections.ObjectModel;
using Chrome.Models;
using Chrome.ViewModels.Design_Data;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

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

    #endregion

    #region HELPERS

    private void RegisterLeftSideBarCommands()
    {

    }

    private void SetTestCustomers()
    {
        Customers = new ObservableCollection<CustomerUiModel>(CustomerGenerator.Generate());
    }

    #endregion
}