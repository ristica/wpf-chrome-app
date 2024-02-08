using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.Views;

public partial class ShellView : Window, IShellView
{
    private IViewModel? _viewModel;

    public ShellView()
    {
        InitializeComponent();
    }

    public void OpenMe()
    {
        this.Show();
    }

    public void CloseMe()
    {
        this.Close();
    }

    public void SetDataContext<T>(T viewModel) where T : IViewModel
    {
        this._viewModel = viewModel;
    }
}