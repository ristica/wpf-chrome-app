using System.Windows;
using Chrome.Bootstrapper;
using Chrome.Common;
using Chrome.Constants;
using Chrome.Dependencies.Builder;
using Chrome.Starter.Properties;
using Chrome.ViewModels.Contracts;
using Localization.WPF;

namespace Chrome.Starter;

public partial class App : Application
{
    private static bool _isLoaded;

    public App()
    {
        SetCulture();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        DependencyManager.Initialize(DependencyContainerFactory.Init());
        DependencyContainerFactory.Container.Resolve<IShellViewModel>().GetView().OpenMe();
        _isLoaded = true;
    }

    private static void SetCulture()
    {
        CultureHandler.ChangeCulture += LocalizationManager.ChangeCulture;

        LocalizationManager.CultureChanging += (s, e) =>
        {
            var culture = e.NewCulture;
            Starter.Properties.Resources.Culture = culture;
        };

        LocalizationManager.CultureChanged += (s, e) =>
        {
            Settings.Default.Culture = e.NewCulture.Name;
            Settings.Default.Save();

            if (!_isLoaded) return;
            DependencyContainerFactory.Container.Resolve<IShellViewModel>().CultureChanged(e.NewCulture.Name);
        };

        // lade Settings falls welche vorhanden ...
        var settings = Settings.Default;
        var lastCulture = settings.Culture;
        var newCulture = string.IsNullOrEmpty(lastCulture) ? Constants.CultureTypes.DeutschCultureId : lastCulture;

        // ... oder von den mitgesendeten Args ...
        var args = Environment.GetCommandLineArgs();
        if (args.Contains("-en")) newCulture = CultureTypes.EnglishCultureId;
        else if (args.Contains("-de")) newCulture = CultureTypes.DeutschCultureId;

        LocalizationManager.ChangeCulture(newCulture);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        CultureHandler.ChangeCulture -= LocalizationManager.ChangeCulture;
        LocalizationManager.CultureChanging -= (s, e) => { };
        LocalizationManager.CultureChanged -= (s, e) => { };

        base.OnExit(e);
    }
}