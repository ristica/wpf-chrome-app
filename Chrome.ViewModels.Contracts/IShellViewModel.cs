using System.Collections.ObjectModel;
using Chrome.Common.Contracts;
using Chrome.Models;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IParentViewModel
{
    string CurrentCultureName { get; }
    bool CanSearch { get; set; }
    string SearchFilter { get; set; }
    bool IsLeftBarExpanded { get; set; }
    bool IsRightBarExpanded { get; set; }
    ObservableCollection<MenuModel>? Favorites { get; }
    ObservableCollection<CustomerUiModel>? Customers { get; }
    IEnumerable<string>? SearchByFilteredItems { get; }
    MenuUiItem SelectedMenu { get; set; }

    void OpenView(string name);
    void AddFavorite(MenuModel? item);
    void RemoveFavorite(MenuModel? item);
    void CultureChanged(string cultureName);
}