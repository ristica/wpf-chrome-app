using System.Windows;
using Chrome.Common.Contracts;
using Chrome.Views.Base;
using Chrome.Views.Contracts;

namespace Chrome.Views.Windows;

public partial class ShellView : BaseView, IShellView
{
    public event EventHandler<WindowState>? WindowStateChanged;
    public event EventHandler? WindowLoaded;

    public WindowState CurrentWindowState => this.WindowState;

    public ShellView()
    {
        InitializeComponent();
    }

    protected override void BaseWindowLoaded(object sender, RoutedEventArgs e)
    {

        if (TopBarUserControl.PART_ChromeTitleBar is { } titleBar)
        {
            titleBar.MouseLeftButtonDown += (s, a) =>
            {
                if (a.ClickCount != 2 || ResizeMode != ResizeMode.CanResize) return;
                base.ToggleWindowState();
                WindowStateChanged?.Invoke(this, this.WindowState);
            };
        }

        WindowLoaded?.Invoke(this, EventArgs.Empty);

        base.BaseWindowLoaded(sender, e);
    }
}