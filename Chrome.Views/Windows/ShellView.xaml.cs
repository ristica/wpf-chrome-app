using System.Windows;
using Chrome.Constants;
using Chrome.Views.Base;
using Chrome.Views.Contracts;

namespace Chrome.Views.Windows;

public partial class ShellView : BaseView, IShellView
{
    public event EventHandler<WindowState>? WindowStateChanged;
    public event EventHandler? WindowLoaded;

    public WindowState CurrentWindowState => WindowState;

    public ShellView()
    {
        InitializeComponent();
        SetWindowName();
        //this.WindowState = WindowState.Maximized;
    }

    protected sealed override void SetWindowName()
    {
        Name = WindowIdentifiers.ShellWindow;
    }

    protected override void BaseWindowLoaded(object sender, RoutedEventArgs e)
    {
        WindowLoaded?.Invoke(this, EventArgs.Empty);

        base.BaseWindowLoaded(sender, e);
    }
}