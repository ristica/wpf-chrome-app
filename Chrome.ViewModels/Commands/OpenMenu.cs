using System.Diagnostics;
using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Models;

namespace Chrome.ViewModels.Commands;

public class OpenMenu(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        var menuUiItem = parameter as MenuUiItem;
        if (menuUiItem == null) return;
        if (menuUiItem == viewModel.SelectedMenu) return;

        viewModel.SelectedMenu = menuUiItem;

        Debug.Print($"\t*** {menuUiItem.Parent?.ParentIdDe}");
    }

    public event EventHandler? CanExecuteChanged;
}