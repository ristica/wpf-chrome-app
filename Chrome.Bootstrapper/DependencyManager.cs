using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows.Shell;
using Chrome.ViewModels.Windows.Uebersicht;
using Chrome.Views.Contracts;
using Chrome.Views.Contracts.Uebersicht;
using Chrome.Views.Windows;
using Chrome.Views.Windows.Uebersicht;

namespace Chrome.Bootstrapper;

public static class DependencyManager
{
    public static void Initialize(IDependencyContainer container)
    {
        container.RegisterTypeAsSingleton<IShellView, ShellView>();
        container.RegisterType<IUebersichtAktionUserControl, UbersichtAktion>();

        container.RegisterTypeAsSingleton<IShellViewModel, ShellViewModel>();
        container.RegisterMultipleOfType<IUserControlParentViewModel, UebersichtAktionViewModel>(Constants
            .WindowIdentifiers.Uebersicht.Aktionen);
    }
}