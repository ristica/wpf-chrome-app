using System.Windows.Input;
using Chrome.ViewModels.Commands.Common;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region COMMANDS

    public ICommand? MinimizeCommand { get; private set; }
    public ICommand? MaximizeCommand { get; private set; }
    public ICommand? CloseCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterTopBarCommands()
    {
        MinimizeCommand = new MinimizeWindowCommand(this);
        MaximizeCommand = new MaximizeWindowCommand(this);
        CloseCommand = new CloseWindowCommand(this);
    }

    #endregion
}