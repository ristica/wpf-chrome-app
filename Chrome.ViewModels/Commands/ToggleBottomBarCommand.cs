using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class ToggleBottomBarCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.IsBottomBarVisible = !viewModel.IsBottomBarVisible;
    }

    public event EventHandler? CanExecuteChanged;
}