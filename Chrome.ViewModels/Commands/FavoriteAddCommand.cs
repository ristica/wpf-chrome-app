using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Models;

namespace Chrome.ViewModels.Commands;

public class FavoriteAddCommand(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter) => true; //viewModel.Favorites == null || viewModel.Favorites.Count < 5;

    public void Execute(object? parameter)
    {
        viewModel.AddFavorite(parameter as MenuModel);
    }

    public event EventHandler? CanExecuteChanged;
}