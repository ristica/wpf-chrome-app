using Chrome.Common.Contracts;
using Chrome.Views.Base;
using Chrome.Views.Contracts.Uebersicht;

namespace Chrome.Views.Windows.Uebersicht;

public partial class UbersichtAktion : BaseUserControl, IUebersichtAktionUserControl
{
    public UbersichtAktion()
    {
        InitializeComponent();
    }

    public void SetDataContext<T>(T? viewModel) where T : IUserControlParentViewModel
    {
        ViewModel = viewModel;
    }
}