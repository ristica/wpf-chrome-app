using Chrome.Common.Contracts;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Contracts.Uebersicht;
using Chrome.Views.Contracts;
using Chrome.Views.Contracts.Uebersicht;

namespace Chrome.ViewModels.Windows.Uebersicht;

public class UebersichtAktionViewModel : ViewModel, IUebersichtAktionViewModel
{
    public IUserControl? UserControl { get; set; }

    public IUserControlParentViewModel? ParentViewModel { get; set; }

    public UebersichtAktionViewModel(IUebersichtAktionUserControl userControl)
    {
        UserControl = userControl;

        // further initializations
        // ...

        UserControl.SetDataContext<IUebersichtAktionViewModel>(this);
    }

    public IUserControl? GetUserControl()
    {
        return UserControl;
    }

    protected override void DisposeViewModel()
    {
    }

    public void SetDataContext(IUserControlParentViewModel viewModel)
    {
        ParentViewModel = viewModel;
    }
}