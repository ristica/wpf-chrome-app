using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using Chrome.Common.Contracts;
using Chrome.Constants;
using Chrome.Models;
using Chrome.ViewModels.Commands.Shell;
using Chrome.ViewModels.Design_Data;
using MaterialDesignThemes.Wpf;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<MenuUiItem>? _menuItems;
    private bool _snackBarIsActive;
    private string? _snackBarText;
    private SnackBarType _snackBarType;
    private SelectedMenuItem? _selectedMenu;
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

    public ObservableCollection<MenuUiItem>? MenuItems
    {
        get => _menuItems;
        set
        {
            _menuItems = value;
            OnPropertyChanged();
        }
    }

    public SelectedMenuItem? SelectedMenu
    {
        get => _selectedMenu;
        set
        {
            _selectedMenu = value;
            OnPropertyChanged();
        }
    }

    public IUserControl? CurrentUserControl
    {
        get => _currentUserControl;
        set
        {
            _currentUserControl = value;
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
    public ICommand CloseMenu { get; private set; }

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
        UpdateMenuItemsFavorite(item, true);

        ShowSnackBar(SnackBarType.Success, "Zur Favoritenliste erfolgreich hinzugefügt!");
    }

    public void RemoveFavorite(MenuModel? item)
    {
        if (item == null) return;
        if (MenuItems == null) return;
        if (Favorites == null) return;

        MenuModel? found = null;

        foreach (var ci in MenuItems)
        {
            var children = ci.Children;
            found = children.SingleOrDefault(c => c.HeaderDe == item.HeaderDe);
            if (found != null) break;
        }

        if (found == null) return;

        Favorites.Remove(found);
        UpdateMenuItemsFavorite(item, false);

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
        CloseMenu = new CloseMenu(this);
    }

    // ToDo: get data from the database !!!
    private void LoadMenuItems()
    {
        var menus = CarouselMenuGenerator.Generate();

        var items = (
                from @group in menus.GroupBy(g => g.ParentIdDe)
                let parent = @group.SingleOrDefault(p => p.ParentIdDe == p.HeaderDe)
                let children = @group.Where(x => x.ParentIdDe != x.HeaderDe).ToList()
                select new MenuUiItem { Parent = parent, Children = children })
            .ToList();

        MenuItems = new ObservableCollection<MenuUiItem>(items);
        SetSearchFunctionality();
    }

    private void UpdateMenuItemsFavorite(MenuModel item, bool add)
    {
        foreach (var ui in MenuItems!)
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