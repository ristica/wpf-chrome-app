using System.Collections.ObjectModel;
using System.Windows.Input;
using Chrome.ViewModels.Commands;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _canSearch;
    private string _searchFilter = null!;
    private ObservableCollection<string> _filteredItems = null!;

    #endregion

    #region PROPERTIES

    public bool CanSearch
    {
        get => _canSearch;
        set
        {
            _canSearch = value;
            OnPropertyChanged();
        }
    }

    public string SearchFilter
    {
        get => _searchFilter;
        set
        {
            _searchFilter = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string>? FilteredItems
    {
        get => _filteredItems;
        set
        {
            _filteredItems = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public ICommand? ToggleSearchCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterSearchBarCommands()
    {
        ToggleSearchCommand = new ToggleSearchCommand(this);
    }

    #endregion
}