using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Shell;

public class ToggleSearchCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.CanSearch = !viewModel.CanSearch;
        if (!viewModel.CanSearch) viewModel.SearchFilter = string.Empty;
    }

    public event EventHandler? CanExecuteChanged;
}