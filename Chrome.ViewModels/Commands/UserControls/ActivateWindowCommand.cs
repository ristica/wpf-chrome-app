using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.UserControls;

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