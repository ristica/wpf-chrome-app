using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class ToggleLanguagePopupCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.IsLanguagePopupOpen = !viewModel.IsLanguagePopupOpen;
    }

    public event EventHandler? CanExecuteChanged;
}