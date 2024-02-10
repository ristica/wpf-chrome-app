using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Contracts;
using Chrome.Views.Contracts;
// ReSharper disable EventUnsubscriptionViaAnonymousDelegate

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
        SubscribeToShellEvents();

        _view.SetDataContext(this);
    }

    private void RegisterCommands()
    {
        RegisterTopBarCommands();
        RegisterSearchBarCommands();
    }

    #endregion

    #region METHODS

    public override void Dispose()
    {
        this._view.WindowStateChanged -= (s, a) => { };

        base.Dispose();
    }

    #endregion

    #region HELPERS

    private void SubscribeToShellEvents()
    {
        this._view.WindowStateChanged += (s, a) =>
        {
            OnPropertyChanged(nameof(CurrentWindowState));
        };
    }

    #endregion
}