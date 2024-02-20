using System.Windows.Controls;
using Chrome.Common.Contracts;
using Chrome.Views.Contracts.Uebersicht;

namespace Chrome.Views.Windows.Uebersicht;

public partial class UbersichtAktion : UserControl, IUebersichtAktionUserControl
{
    public UbersichtAktion()
    {
        InitializeComponent();
    }

    public IUserControlParentViewModel ViewModel { get; private set; }

    public void SetDataContext<T>(T viewModel) where T : IUserControlParentViewModel
    {
        this.ViewModel = viewModel;
    }
}