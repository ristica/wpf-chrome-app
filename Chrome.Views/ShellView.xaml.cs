using System.Windows;
using Chrome.Common;
using Chrome.Views.Contracts;

namespace Chrome.Views;

public partial class ShellView : IShellView
{
    public ShellView()
    {
        InitializeComponent();
    }

    public IParentViewModel ViewModel { get; private set; }

    public void OpenMe()
    {
        Show();
    }

    public void CloseMe()
    {
        Close();
    }

    public void MaximizeView()
    {
        ToggleWindowState();
    }

    public void MinimizeView()
    {
        WindowState = WindowState.Minimized;
    }

    public void SetDataContext<T>(T viewModel) where T : IParentViewModel
    {
        ViewModel = viewModel;
    }

    protected override void ShellBaseWindowLoaded(object sender, RoutedEventArgs e)
    {
        if (TopBarUserControl.PART_ChromeTitleBar is { } titleBar)
        {
            titleBar.MouseLeftButtonDown += (s, e) => DragMove();
            titleBar.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ClickCount == 2
                    && ResizeMode == ResizeMode.CanResize)
                    ToggleWindowState();
            };
        }

        base.ShellBaseWindowLoaded(sender, e);
    }
}