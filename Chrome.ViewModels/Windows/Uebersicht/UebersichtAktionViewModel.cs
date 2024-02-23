using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts.Uebersicht;
using Chrome.ViewModels.Contracts;
using Chrome.ViewModels.Windows.Base;

namespace Chrome.ViewModels.Windows.Uebersicht;

public class UebersichtAktionViewModel 
    : UserControlBaseViewModel, IUebersichtAktionViewModel
{
    public UebersichtAktionViewModel(IDependencyContainer container) 
        : base(container, Constants.WindowIdentifiers.Uebersicht.Aktionen)
    {
        WindowTitle = "Test Window";

        base.SetWindowInstanceViewModel(this);
    }

    public void DisposeMe()
    {
        this.DisposeViewModel();
    }

    protected override void DisposeViewModel()
    {
        var vm = base.Container.Resolve<IShellViewModel>();
        vm.Views.Remove(this.GetUserControl());
        vm.CurrentUserControl = null;
    }
}