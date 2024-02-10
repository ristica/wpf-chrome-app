using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Contracts;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels;

public partial class ShellViewModel : ViewModel, IShellViewModel
{
    #region FIELDS

    private readonly IShellView _view;

    #endregion

    #region PROPERTIES

    public IShellView GetView()
    {
        return _view;
    }

    #endregion

    #region C-TOR

    public ShellViewModel(IDependencyContainer container)
    {
        _view = container.Resolve<IShellView>();

        RegisterCommands();

        _view.SetDataContext(this);
    }

    private void RegisterCommands()
    {
        RegisterTopBarCommands();
        RegisterSearchBarCommands();
    }

    #endregion

    #region METHODS

    #endregion

    #region HELPERS

    #endregion
}