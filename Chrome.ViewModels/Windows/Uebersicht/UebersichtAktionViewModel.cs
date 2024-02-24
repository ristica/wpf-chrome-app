using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts.Uebersicht;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows.Base;

namespace Chrome.ViewModels.Windows.Uebersicht;

// ReSharper disable once ClassNeverInstantiated.Global
public class UebersichtAktionViewModel 
    : UserControlBaseViewModel, IUebersichtAktionViewModel
{
    public UebersichtAktionViewModel(IDependencyContainer container) 
        : base(container, Constants.WindowIdentifiers.Uebersicht.Aktionen)
    {
        WindowTitle = "Test Window";
        WindowIdentifier = Constants.WindowIdentifiers.Uebersicht.Aktionen;

        base.SetWindowInstanceViewModel(this);
    }

    public void DisposeMe()
    {
        // publish notification
        // ...

        this.DisposeViewModel();
    }

    protected override void DisposeViewModel()
    {
        
    }
}