using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.Common;

public class MarkerDeactivateCommand(IUserControlParentViewModel? viewModel) : ICommand
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