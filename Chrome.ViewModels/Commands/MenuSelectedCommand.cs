using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Constants;

namespace Chrome.ViewModels.Commands;

public class MenuSelectedCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;

        // ToDo: at the time only one implementation !!!
        if (parameter.ToString()!.Equals(WindowIdentifiers.Uebersicht.Aktionen))
            viewModel.OpenView(parameter.ToString()!);
    }

    public event EventHandler? CanExecuteChanged;
}