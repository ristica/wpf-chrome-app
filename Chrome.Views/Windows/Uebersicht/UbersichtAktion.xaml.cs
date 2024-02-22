using Chrome.Common.Contracts;
using Chrome.Views.Base;
using Chrome.Views.Contracts.Uebersicht;

namespace Chrome.Views.Windows.Uebersicht;

public partial class UbersichtAktion : BaseUserControl, IUebersichtAktionUserControl
{
    public UbersichtAktion()
    {
        InitializeComponent();
        this.SetTopBar();
    }

    public IUserControlParentViewModel? ViewModel { get; private set; }

    public void SetDataContext<T>(T? viewModel) where T : IUserControlParentViewModel
    {
        ViewModel = viewModel;
    }

    protected sealed override void SetTopBar()
    {
        base.TopBar = this.BorderTopBar;
    }
}