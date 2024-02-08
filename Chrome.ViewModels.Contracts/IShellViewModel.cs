using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface IShellViewModel : IViewModel
{
    bool CanClose { get; set; }
    void CloseView();
    ResizeMode ResizeMode { get; set; }
    IShellView GetView();
    void OpenView();
}