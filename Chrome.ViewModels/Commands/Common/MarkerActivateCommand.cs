using Chrome.Common.Contracts;
using System.Windows.Input;

namespace Chrome.ViewModels.Commands.Common;

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