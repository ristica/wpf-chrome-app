using System.Collections.ObjectModel;
using System.Windows.Threading;
using Chrome.Common.Contracts;
using Chrome.Constants;
using Chrome.Models;
using Chrome.ViewModels.Commands;
using Chrome.ViewModels.Design_Data;
using Chrome.Views.Contracts;
using MaterialDesignThemes.Wpf;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<MenuUiItem>? _carouselItems;
    private bool _snackBarIsActive;
    private string? _snackBarText;
    private SnackBarType _snackBarType;
    private MenuUiItem _selectedMenu;
    private IUserControl? _currentUserControl;

    #endregion

    #region PROPERTIES

    public bool SnackBarIsActive
    {
        get => _snackBarIsActive;
        set
        {
            _snackBarIsActive = value;
            OnPropertyChanged();
        }
    }

    public string? SnackBarText
    {
        get => _snackBarText;
        set
        {
            _snackBarText = value;
            OnPropertyChanged();
        }
    }

    public SnackBarType SnackBarType
    {
        get => _snackBarType;
        set
        {
            _snackBarType = value;
            OnPropertyChanged();
        }
    }

    public SnackbarMessageQueue MessageQueue { get; private set; }

    public ObservableCollection<MenuUiItem>? CarouselItems
    {
        get => _carouselItems;
        set
        {
            _carouselItems = value;
            OnPropertyChanged();
        }
    }

    public MenuUiItem SelectedMenu
    {
        get => this._selectedMenu;
        set
        {
            this._selectedMenu = value;
            OnPropertyChanged();
        }
    }

    public IUserControl? CurrentUserControl
    {
        get => this._currentUserControl;
        set
        {
            this._currentUserControl = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public FavoriteAddCommand? FavoriteAddCommand { get; private set; }
    public FavoriteRemoveCommand? FavoriteRemoveCommand { get; private set; }
    public MenuSelectedCommand? MenuSelectedCommand { get; private set; }
    public ToggleLeftSideBarCommand ToggleLeftSideBarCommand { get; private set; }
    public ToggleRightSideBarCommand ToggleRightSideBarCommand { get; private set; }
    public OpenMenu OpenMenu { get; private set; }

    #endregion

    #region METHODS

    public void AddFavorite(MenuModel? item)
    {
        if (item == null) return;
        Favorites ??= new ObservableCollection<MenuModel>();
        if (Favorites.Count > 4)
        {
            ShowSnackBar(SnackBarType.Error, "Die Favoritenliste ist voll!");
            return;
        }

        var found = Favorites.SingleOrDefault(f => f.HeaderDe == item.HeaderDe);
        if (found != null) return;

        Favorites.Add(item);
        UpdateCarouselItemsFavorite(item, true);

        ShowSnackBar(SnackBarType.Success, "Zur Favoritenliste erfolgreich hinzugefügt!");
    }

    public void RemoveFavorite(MenuModel? item)
    {
        if (item == null) return;
        if (CarouselItems == null) return;
        if (Favorites == null) return;

        MenuModel? found = null;

        foreach (var ci in CarouselItems)
        {
            var children = ci.Children;
            found = children.SingleOrDefault(c => c.HeaderDe == item.HeaderDe);
            if (found != null) break;
        }

        if (found == null) return;

        Favorites.Remove(found);
        UpdateCarouselItemsFavorite(item, false);

        ShowSnackBar(SnackBarType.Info, "Aus der Favoritenliste erfolgreich entfernt!");
    }

    #endregion

    #region HELPERS

    private void RegisterShellContentCommands()
    {
        FavoriteAddCommand = new FavoriteAddCommand(this);
        FavoriteRemoveCommand = new FavoriteRemoveCommand(this);
        MenuSelectedCommand = new MenuSelectedCommand(this);
        ToggleLeftSideBarCommand = new ToggleLeftSideBarCommand(this);
        ToggleRightSideBarCommand = new ToggleRightSideBarCommand(this);
        OpenMenu = new OpenMenu(this);
    }

    // ToDo: get data from the database !!!
    private void SetCarouselItems()
    {
        var menus = CarouselMenuGenerator.Generate();

        var items = (
                from @group in menus.GroupBy(g => g.ParentIdDe)
                let parent = @group.SingleOrDefault(p => p.ParentIdDe == p.HeaderDe)
                let children = @group.Where(x => x.ParentIdDe != x.HeaderDe).ToList()
                select new MenuUiItem { Parent = parent, Children = children })
            .ToList();

        CarouselItems = new ObservableCollection<MenuUiItem>(items);
        this.SetSearchFunctionality(); 
    }

    private void UpdateCarouselItemsFavorite(MenuModel item, bool add)
    {
        foreach (var ui in CarouselItems!)
        foreach (var child in ui.Children.Where(child => child!.Id == item.Id))
        {
            child!.IsFavorite = add;
            break;
        }

        if (!Favorites!.Any()) Favorites = null;
    }

    private void ShowSnackBar(SnackBarType sbt, string? message)
    {
        if (SnackBarIsActive)
        {
            if (SnackBarType == sbt) return;
            SnackBarIsActive = false;
        }

        SnackBarType = sbt;
        SnackBarIsActive = true;
        SnackBarText = message;

        Task.Run(() => Thread.Sleep(2000))
            .ContinueWith(t => { Dispatcher.CurrentDispatcher.Invoke(() => { SnackBarIsActive = false; }); });
    }

    #endregion
}