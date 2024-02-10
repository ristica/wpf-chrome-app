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

    public IShellView GetView() => this._view;

    #endregion

    #region C-TOR

    public ShellViewModel(IDependencyContainer container)
    {
        this._view = container.Resolve<IShellView>();

        RegisterCommands();
        SubscribeToShellEvents();

        this._view.SetDataContext(this);
    }

    private void RegisterCommands()
    {
        RegisterTopBarCommands();
        RegisterBottomLanguageBarCommands();
        RegisterSearchBarCommands();
        RegisterSideBarCommands();
    }

    #endregion

    #region METHODS

    protected override void DisposeViewModel()
    {
        this._view.WindowLoaded -= (s, a) => { };
        this._view.WindowStateChanged -= (s, a) => { };
    }

    #endregion

    #region HELPERS

    private void SubscribeToShellEvents()
    {
        this._view.WindowLoaded += (s, a) =>
        {
           
        };

        this._view.WindowStateChanged += (s, a) =>
        {
            OnPropertyChanged(nameof(CurrentWindowState));
        };
    }

    #endregion
}