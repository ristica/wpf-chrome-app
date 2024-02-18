using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows.Input;
using Chrome.Constants;
using Chrome.Models;
using Chrome.ViewModels.Commands;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private bool _canSearch;
    private string _searchFilter = null!;
    private IDisposable? _menuListItemsChangedSubscription;
    private ObservableCollection<string>? _filteredItems = new ();

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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            _searchFilter = value == null ? string.Empty : value; // clear button in input control sets it to NULL !!!
            OnPropertyChanged();
        }
    }

    public IEnumerable<string>? SearchByFilteredItems => this._filteredItems;

    #endregion

    #region COMMANDS

    public ICommand? ToggleSearchCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterSearchBarCommands()
    {
        ToggleSearchCommand = new ToggleSearchCommand(this);
    }

    private void SetSearchFunctionality()
    {
        this.SearchFilter = string.Empty;
        OnPropertyChanged(nameof(SearchFilter));

        var menuModelList = new List<MenuModel?>();
        foreach (var ci in this.CarouselItems!)
        {
            menuModelList.AddRange(ci.Children);
        }

        this._menuListItemsChangedSubscription =
            Observable
                .FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
                    h => PropertyChanged += h,
                    h => PropertyChanged -= h)
                .Where(e => e.EventArgs.PropertyName == nameof(SearchFilter))
                .Select(_ => menuModelList)
                .Select(menus => 
                    menus.Where(m =>
                            this.CurrentCultureName.Equals(CultureTypes.DeutschCultureId)
                                ? m!.HeaderDe.Contains(this.SearchFilter, StringComparison.InvariantCultureIgnoreCase)
                                : !string.IsNullOrEmpty(m?.HeaderEn) && m.HeaderEn.Contains(this.SearchFilter, StringComparison.InvariantCultureIgnoreCase)))
                .Subscribe(menus =>
                {
                    this._filteredItems?.Clear();

                    foreach (var m in menus)
                    {
                        switch (this.CurrentCultureName)
                        {
                            case CultureTypes.DeutschCultureId:
                                this._filteredItems?.Add($"{m!.ParentIdDe} - {m.HeaderDe}");
                                break;
                            case CultureTypes.EnglishCultureId:
                                if (m?.HeaderEn != null) 
                                    this._filteredItems?.Add($"{m.ParentIdEn} - {m.HeaderEn}");
                                break;
                        }
                    }
                });
    }

    #endregion
}