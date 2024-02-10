using System.Collections.ObjectModel;
using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IParentViewModel
{
    bool CanClose { get; }
    void CloseView();
    ResizeMode ResizeMode { get; }
    WindowState CurrentWindowState { get; }
    IShellView GetView();
    void OpenView();
    void MaximizeView();
    void MinimizeView();

    bool CanSearch { get; set; }
    string SearchFilter { get; set; }
    ObservableCollection<string> FilteredItems { get; set; }
}