using System.Windows;
using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.Common;

public class MaximizeWindowCommand(IParentViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return viewModel.ResizeMode != ResizeMode.NoResize;
    }

    public void Execute(object? parameter)
    {
        viewModel.MaximizeView();
    }

    public event EventHandler? CanExecuteChanged;
}