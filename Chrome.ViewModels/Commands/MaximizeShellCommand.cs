using System.Windows;
using System.Windows.Input;
using Chrome.ViewModels.Contracts;

namespace Chrome.ViewModels.Commands;

public class MaximizeShellCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return viewModel.ResizeMode != ResizeMode.NoResize;
    }

    public void Execute(object? parameter)
    {
        if (viewModel.ResizeMode == ResizeMode.CanResize) viewModel.MaximizeView();
    }

    public event EventHandler? CanExecuteChanged;
}