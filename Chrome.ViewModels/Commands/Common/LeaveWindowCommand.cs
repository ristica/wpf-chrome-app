using Chrome.Common.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Common;

public class LeaveWindowCommand(IUserControlParentViewModel? viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.GetUserControl()?.OnUserControlMouseLeave();
    }

    public event EventHandler? CanExecuteChanged;
}