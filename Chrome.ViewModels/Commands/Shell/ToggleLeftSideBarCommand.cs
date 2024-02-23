using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Shell;

public class ToggleLeftSideBarCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.IsLeftBarExpanded = !viewModel.IsLeftBarExpanded;
    }

    public event EventHandler? CanExecuteChanged;
}