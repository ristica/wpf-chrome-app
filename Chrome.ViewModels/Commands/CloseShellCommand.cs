using System.Windows.Input;
using Chrome.ViewModels.Contracts;

namespace Chrome.ViewModels.Commands;

public class CloseShellCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.CloseView();
    }

    public event EventHandler? CanExecuteChanged;
}