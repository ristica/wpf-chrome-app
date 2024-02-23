using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows.Shell;
using Chrome.ViewModels.Windows.Uebersicht;
using Chrome.Views.Contracts;
using Chrome.Views.Windows;
using Chrome.Views.Windows.Uebersicht;

namespace Chrome.Bootstrapper;

public static class DependencyManager
{
    public static void Initialize(IDependencyContainer container)
    {
        container.RegisterTypeAsSingleton<IShellView, ShellView>(); // !!!
        container.RegisterTypeAsSingleton<IShellViewModel, ShellViewModel>(); // !!!

        container.RegisterMultipleOfType<IUserControl, UbersichtAktion>(Constants.WindowIdentifiers.Uebersicht.Aktionen);
        container.RegisterMultipleOfType<IUserControlParentViewModel, UebersichtAktionViewModel>(Constants.WindowIdentifiers.Uebersicht.Aktionen);
    }
}