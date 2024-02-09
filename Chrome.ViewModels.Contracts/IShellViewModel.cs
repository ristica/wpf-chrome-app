using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IParentViewModel
{
    bool CanClose { get; }
    void CloseView();
    ResizeMode ResizeMode { get; }
    IShellView GetView();
    void OpenView();
    void MaximizeView();
    void MinimizeView();
}