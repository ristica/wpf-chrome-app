using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Contracts;
using Chrome.Views.Contracts;
using MaterialDesignThemes.Wpf;

// ReSharper disable EventUnsubscriptionViaAnonymousDelegate

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel : ViewModel, IShellViewModel
{
    #region FIELDS

    private readonly IDependencyContainer _container;
    private readonly IShellView _view;

    #endregion

    #region PROPERTIES

    public IView GetView()
    {
        return _view;
    }

    #endregion

    #region C-TOR

    public ShellViewModel(IDependencyContainer container)
    {
        _container = container;
        _view = container.Resolve<IShellView>();
        IsBottomBarVisible = true;

        RegisterCommands();
        SubscribeToShellEvents();

        SetCommonCultures();
        SetCarouselItems();
        SetTestCustomers();
        MessageQueue = new SnackbarMessageQueue(TimeSpan.FromSeconds(5));

        _view.SetDataContext(this);
    }

    private void RegisterCommands()
    {
        RegisterTopBarCommands();
        RegisterBottomLanguageBarCommands();
        RegisterSearchBarCommands();
        RegisterLeftSideBarCommands();
        RegisterRightSideBarCommands();
        RegisterShellContentCommands();
        RegisterBottomBarCommands();
    }

    #endregion

    #region METHODS

    protected override void DisposeViewModel()
    {
        _view.WindowLoaded -= (s, a) => { };
        _view.WindowStateChanged -= (s, a) => { };
    }

    #endregion

    #region HELPERS

    private void SubscribeToShellEvents()
    {
        _view.WindowLoaded += (s, a) => { };

        _view.WindowStateChanged += (s, a) => { OnPropertyChanged(nameof(CurrentWindowState)); };
    }

    #endregion
}