using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Shell;

public class ToggleRightSideBarCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.IsRightBarExpanded = !viewModel.IsRightBarExpanded;
    }

    public event EventHandler? CanExecuteChanged;
}