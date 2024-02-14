using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class ToggleRightBarCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter) => viewModel.Favorites is { Count: > 0 };

    public void Execute(object? parameter)
    {
        viewModel.IsRightBarExpanded = !viewModel.IsRightBarExpanded;
    }

    public event EventHandler? CanExecuteChanged;
}