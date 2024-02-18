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
        if (parameter.ToString().Equals(MenuIdentifiers.Uebersicht.UbersichtAktionen))
        {
            viewModel.OpenTestWindow(parameter.ToString());
        }
    }

    public event EventHandler? CanExecuteChanged;
}