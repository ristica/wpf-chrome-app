using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.Common;

public class DragStartWindowCommand(IUserControlParentViewModel? viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        var args = parameter as MouseButtonEventArgs;
        viewModel.GetUserControl()!.OnTopBarMouseDown(args!);
    }

    public event EventHandler? CanExecuteChanged;
}