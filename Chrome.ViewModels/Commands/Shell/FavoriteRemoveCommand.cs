using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Models;

namespace Chrome.ViewModels.Commands.Shell;

public class FavoriteRemoveCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return viewModel.Favorites?.Count > 0;
    }

    public void Execute(object? parameter)
    {
        viewModel.RemoveFavorite(parameter as MenuModel);
    }

    public event EventHandler? CanExecuteChanged;
}