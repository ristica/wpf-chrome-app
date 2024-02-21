using Chrome.Models;
using Chrome.ViewModels.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands;

public class OpenLanguagePopupCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        viewModel.IsLanguageInfoVisible = true;
    }

    public event EventHandler? CanExecuteChanged;
}