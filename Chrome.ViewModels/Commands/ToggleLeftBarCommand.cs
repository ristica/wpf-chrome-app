using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class ToggleLeftBarCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter) => viewModel.Customers is { Count: > 0 };

    public void Execute(object? parameter)
    {
        viewModel.IsLeftBarExpanded = !viewModel.IsLeftBarExpanded;
    }

    public event EventHandler? CanExecuteChanged;
}