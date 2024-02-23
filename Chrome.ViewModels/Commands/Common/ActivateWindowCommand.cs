using Chrome.Common.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Common;

public class ActivateWindowCommand(IUserControlParentViewModel? viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.GetUserControl()?.OnUserControlActivate();
    }

    public event EventHandler? CanExecuteChanged;
}