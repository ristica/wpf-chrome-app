using Chrome.ViewModels.Commands;
using System.Windows.Input;

namespace Chrome.ViewModels;

public partial class ShellViewModel
{
    #region COMMANDS

    public ICommand? MinimizeShellCommand { get; private set; }
    public ICommand? MaximizeShellCommand { get; private set; }
    public ICommand? CloseShellCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterTopBarCommands()
    {
        MinimizeShellCommand = new MinimizeShellCommand(this);
        MaximizeShellCommand = new MaximizeShellCommand(this);
        CloseShellCommand = new CloseShellCommand(this);
    }

    #endregion
}