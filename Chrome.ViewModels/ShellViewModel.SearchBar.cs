using System.Collections.ObjectModel;
using Chrome.ViewModels.Commands;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _canSearch;
    private string _searchFilter;
    private ObservableCollection<string> _filteredItems;

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

    public ObservableCollection<string> FilteredItems
    {
        get => this._filteredItems;
        set
        {
            this._filteredItems = value;
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