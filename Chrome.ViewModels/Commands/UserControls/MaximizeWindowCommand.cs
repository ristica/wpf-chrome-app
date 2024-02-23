using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.UserControls;

public class MaximizeWindowCommand(IUserControlParentViewModel? viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
    }

    public event EventHandler? CanExecuteChanged;
}