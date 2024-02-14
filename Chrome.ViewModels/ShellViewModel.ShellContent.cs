using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Chrome.Constants;
using Chrome.Models;
using Chrome.ViewModels.Commands;
using MaterialDesignThemes.Wpf;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private ObservableCollection<MenuUiItem>? _carouselItems;
    private bool _snackBarIsActive;
    private string _snackBarText;
    private SnackBarType _snackBarType;

    #endregion

    #region PROPERTIES

    public bool SnackBarIsActive
    {
        get => this._snackBarIsActive;
        set
        {
            this._snackBarIsActive = value;
            OnPropertyChanged();
        }
    }

    public string SnackBarText
    {
        get => this._snackBarText;
        set
        {
            this._snackBarText = value;
            OnPropertyChanged();
        }
    }

    public SnackBarType SnackBarType
    {
        get => this._snackBarType;
        set
        {
            this._snackBarType = value;
            OnPropertyChanged();
        }
    }

    public SnackbarMessageQueue MessageQueue { get; private set; } 

    public ObservableCollection<MenuUiItem>? CarouselItems
    {
        get => this._carouselItems;
        set
        {
            this._carouselItems = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public FavoriteAddCommand? FavoriteAddCommand { get; private set; }
    public FavoriteRemoveCommand? FavoriteRemoveCommand { get; private set; }
    public MenuSelectionChangedCommand? MenuSelectionChangedCommand { get; private set; }

    #endregion

    #region METHODS

    public void AddFavorite(MenuModel? item)
    {
        if (item == null) return;
        this.Favorites ??= new();
        if (this.Favorites.Count > 4)
        {
            this.ShowSnackBar(SnackBarType.Error, "Die Favoritenliste ist voll!");
            return;
        }
        
        var found = this.Favorites.SingleOrDefault(f => f.Header == item.Header);
        if (found != null) return;

        this.Favorites.Add(item);
        this.UpdateCarouselItemsFavorite(item, true);

        this.ShowSnackBar(SnackBarType.Success, "Zur Favoritenliste erfolgreich hinzugefügt!");
    }

    public void RemoveFavorite(MenuModel? item)
    {
        if (item == null) return;
        if (this.CarouselItems == null) return;
        if (this.Favorites == null) return;

        MenuModel? found = null;

        foreach (var ci in this.CarouselItems)
        {
            var children = ci.Children;
            found = children.SingleOrDefault(c => c.Header == item.Header);
            if (found != null) break;
        }

        if (found == null) return;

        this.Favorites.Remove(found);
        this.UpdateCarouselItemsFavorite(item, false);

        this.ShowSnackBar(SnackBarType.Info, "Aus der Favoritenliste erfolgreich entfernt!");
    }

    #endregion

    #region HELPERS

    private void RegisterShellContentCommands()
    {
        this.FavoriteAddCommand = new FavoriteAddCommand(this);
        this.FavoriteRemoveCommand = new FavoriteRemoveCommand(this);
        this.MenuSelectionChangedCommand = new MenuSelectionChangedCommand(this);
    }

    private void SetCarouselItems()
    {
        var menus = Helpers.CarouselMenuGenerator.Generate();

        var dtos = (
                from @group in menus.GroupBy(g => g.ParentId)
                let parent = @group.SingleOrDefault(p => p.ParentId == p.Header)
                let children = @group.Where(x => x.ParentId != x.Header).ToList()
                select new MenuUiItem { Parent = parent, Children = children })
            .ToList();

        this.CarouselItems = new ObservableCollection<MenuUiItem>(dtos);
    }

    private void UpdateCarouselItemsFavorite(MenuModel item, bool add)
    {
        foreach (var ui in this.CarouselItems!)
        {
            foreach (var child in ui.Children.Where(child => child!.Id == item.Id))
            {
                child!.IsFavorite = add;
                break;
            }
        }

        if (!this.Favorites!.Any()) this.Favorites = null;
    }

    private void ShowSnackBar(SnackBarType sbt, string message)
    {
        if (this.SnackBarIsActive)
        {
            if (this.SnackBarType == sbt) return;
            this.SnackBarIsActive = false;
        }

        this.SnackBarType = sbt;
        this.SnackBarIsActive = true;
        this.SnackBarText = message;

        Task.Run(() => Thread.Sleep(5000))
            .ContinueWith(t =>
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    this.SnackBarIsActive = false;
                });
            });
    }

    #endregion
}