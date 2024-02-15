using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class MenuSelectionChangedCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        
    }

    public event EventHandler? CanExecuteChanged;
}