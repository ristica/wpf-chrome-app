using Chrome.Common;
using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Shell;

public class SetLanguageCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is string { Length: > 0 } language) CultureHandler.ChangeCultureAction(language);
    }

    public event EventHandler? CanExecuteChanged;
}