using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.Views;

public partial class ShellView : IShellView
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

    protected override void ShellBaseWindowLoaded(object sender, RoutedEventArgs e)
    {
        if (this.TopBarUserControl.PART_ChromeTitleBar is { } titleBar)
        {
            titleBar.MouseLeftButtonDown += (s, e) => DragMove();
            titleBar.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ClickCount == 2
                    && ResizeMode == ResizeMode.CanResize)
                    base.ToggleWindowState();
            };
        }

        base.ShellBaseWindowLoaded(sender, e);
    }
}