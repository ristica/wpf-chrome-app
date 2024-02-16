using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows;
using Chrome.Views.Contracts;
using Chrome.Views.Windows;
using ShellViewModel = Chrome.ViewModels.Windows.Shell.ShellViewModel;

namespace Chrome.Bootstrapper;

public static class DependencyManager
{
    public static void Initialize(IDependencyContainer container)
    {
        container.RegisterType<IShellView, ShellView>();
        container.RegisterType<ITestView, TestView>();

        container.RegisterType<IShellViewModel, ShellViewModel>();
        container.RegisterType<ITestViewModel, TestViewModel>();
    }
}