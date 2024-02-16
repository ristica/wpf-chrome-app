using System.Collections.ObjectModel;
using System.Windows;
using Chrome.Common.Contracts;
using Chrome.Models;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IParentViewModel
{
    bool CanSearch { get; set; }
    string SearchFilter { get; set; }
    ObservableCollection<string>? FilteredItems { get; set; }
    ObservableCollection<MenuModel>? Favorites { get; }
    ObservableCollection<CustomerUiModel>? Customers { get; }
    bool IsBottomBarVisible { get; set; }

    IShellView GetView();
    void OpenView();
    void OpenTestWindow();
    void AddFavorite(MenuModel? item);
    void RemoveFavorite(MenuModel? item);
}