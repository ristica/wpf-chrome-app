using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows;
using Chrome.ViewModels.Windows.Shell;
using Chrome.Views.Contracts;
using Chrome.Views.Windows;

namespace Chrome.Bootstrapper;

public static class DependencyManager
{
    public static void Initialize(IDependencyContainer container)
    {
        container.RegisterTypeAsSingleton<IShellView, ShellView>();
        container.RegisterType<IUebersichtAktionenView, UebersichtAktionenView>();

        container.RegisterTypeAsSingleton<IShellViewModel, ShellViewModel>();
        container.RegisterMultipleOfType<IParentViewModel, UebersichtAktionenViewModel>(nameof(IUebersichtAktionenViewModel));
    }
}