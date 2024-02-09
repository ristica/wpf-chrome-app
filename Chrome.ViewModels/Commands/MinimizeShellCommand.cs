using System.Windows;
using System.Windows.Input;
using Chrome.ViewModels.Contracts;

namespace Chrome.ViewModels.Commands;

public class MinimizeShellCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        if (viewModel.ResizeMode == ResizeMode.NoResize) return viewModel.ResizeMode == ResizeMode.CanMinimize;

        return true;
    }


    public void Execute(object? parameter)
    {
        viewModel.MinimizeView();
    }

    public event EventHandler? CanExecuteChanged;
}