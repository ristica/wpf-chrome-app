using System.Windows;
using Chrome.Bootstrapper;
using Chrome.Dependencies.Builder;
using Chrome.ViewModels.Contracts;

namespace Chrome.Starter;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        DependencyManager.Initialize(DependencyContainerFactory.Init());

        DependencyContainerFactory.Container.Resolve<IShellViewModel>().GetView().OpenMe();
    }
}