using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.Common;

public class DragWindowCommand(IParentViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.DragWindow();
    }

    public event EventHandler? CanExecuteChanged;
}