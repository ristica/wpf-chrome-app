using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.UserControls;

public class MarkerActivateCommand(IUserControlParentViewModel? viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        var args = parameter as string;
        viewModel.GetUserControl()?.OnMarkerMouseDown(args);
    }

    public event EventHandler? CanExecuteChanged;
}