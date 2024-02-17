using System.Windows.Input;
using Chrome.ViewModels.Commands;
using Chrome.ViewModels.Contracts;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    #endregion

    #region COMMAND

    public ICommand? OpenTestWindowCommand { get; private set; }

    #endregion

    #region METHODS

    public void OpenTestWindow()
    {
        _container.Resolve<ITestViewModel>().GetView().OpenMe();
    }

    #endregion

    #region HELPERS

    private void RegisterBottomBarCommands()
    {
        OpenTestWindowCommand = new OpenTestWindowCommand(this);
    }

    #endregion
}