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

    public IParentViewModel ViewModel { get; private set; } = null!;

    public WindowState CurrentWindowState => this.WindowState;

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
            titleBar.MouseLeftButtonDown += (s, a) => DragMove();
            titleBar.MouseLeftButtonDown += (s, a) =>
            {
                if (a.ClickCount != 2 || ResizeMode != ResizeMode.CanResize) return;
                ToggleWindowState();
                WindowStateChanged?.Invoke(this, this.WindowState);
            };
        }

        WindowLoaded.Invoke(this, EventArgs.Empty);

        base.ShellBaseWindowLoaded(sender, e);
    }

    public event EventHandler<WindowState> WindowStateChanged;
    public event EventHandler WindowLoaded;
}