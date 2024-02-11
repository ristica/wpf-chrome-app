using System.Collections.ObjectModel;
using Chrome.Models;
using Chrome.ViewModels.Commands;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region FIELDS

    private MenuUiItem _selectedCarouselItem;
    private ObservableCollection<MenuUiItem>? _carouselItems;
    private ObservableCollection<MenuModel>? _favorites;

    #endregion

    #region PROPERTIES

    public MenuUiItem SelectedCarouselItem
    {
        get => this._selectedCarouselItem;
        set
        {
            this._selectedCarouselItem = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<MenuUiItem>? CarouselItems
    {
        get => this._carouselItems;
        set
        {
            this._carouselItems = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<MenuModel>? Favorites
    {
        get => this._favorites;
        private set
        {
            this._favorites = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region COMMANDS

    public FavoriteAddCommand? FavoriteAddCommand { get; private set; }
    public FavoriteRemoveCommand? FavoriteRemoveCommand { get; private set; }

    #endregion

    #region METHODS

    public void AddFavorite(MenuModel? item)
    {
        if (item == null) return;
        this.Favorites ??= new();
        if (this.Favorites.Count > 4) return;
        
        var found = this.Favorites.SingleOrDefault(f => f.Header == item.Header);
        if (found != null) return;

        this.Favorites.Add(item);
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
    }

    #endregion

    #region HELPERS

    private void RegisterShellContentCommands()
    {
        this.FavoriteAddCommand = new FavoriteAddCommand(this);
        this.FavoriteRemoveCommand = new FavoriteRemoveCommand(this);
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

    #endregion
}