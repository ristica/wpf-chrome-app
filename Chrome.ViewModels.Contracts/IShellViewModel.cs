using System.Collections.ObjectModel;
using System.Windows;
using Chrome.Common.Contracts;
using Chrome.Models;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IParentViewModel
{
    bool CanClose { get; }
    ResizeMode ResizeMode { get; }
    WindowState CurrentWindowState { get; }
    bool CanSearch { get; set; }
    string SearchFilter { get; set; }
    bool IsLeftBarExpanded { get; set; }
    bool IsRightBarExpanded { get; set; }
    ObservableCollection<string>? FilteredItems { get; set; }
    ObservableCollection<MenuModel>? Favorites { get; }
    ObservableCollection<CustomerUiModel>? Customers { get; }
    bool IsLanguagePopupOpen { get; set; }
    bool IsBottomBarVisible { get; set; }

    IShellView GetView();
    void OpenView();
    void MaximizeView();
    void MinimizeView();
    void AddFavorite(MenuModel? item);
    void RemoveFavorite(MenuModel? item);
    void CloseView();
}