using Chrome.Dependencies.Contracts;
using Chrome.ViewModels;
using Chrome.ViewModels.Contracts;
using Chrome.Views;
using Chrome.Views.Contracts;

namespace Chrome.Bootstrapper;

public static class DependencyManager
{
    public static void Initialize(IDependencyContainer container)
    {
        container.RegisterType<IShellView, ShellView>();
        container.RegisterType<IShellViewModel, ShellViewModel>();
    }
}