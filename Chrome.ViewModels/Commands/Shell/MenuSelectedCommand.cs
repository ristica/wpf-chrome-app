using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Shell;

public class MenuSelectedCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        viewModel.AddView(parameter.ToString()!);
    }

    public event EventHandler? CanExecuteChanged;
}