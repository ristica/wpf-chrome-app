using System.Windows;
using System.Windows.Controls;
using Chrome.Common.Contracts;
using Chrome.Views.Contracts;
using Chrome.Views.ShellUserControls;

namespace Chrome.Views.Windows;

public partial class TestView : ITestView
{
    public TestView()
    {
        InitializeComponent();
        this.Loaded += (s, e) =>
        {
            var titleBar = this.FindName("PART_ChromeTitleBar");
            if (titleBar is Border tb)
            {
                tb.MouseLeftButtonDown += (s, a) => DragMove();
                tb.MouseLeftButtonDown += (s, a) =>
                {
                    if (a.ClickCount != 2 || ResizeMode != ResizeMode.CanResize) return;
                    ToggleWindowState();
                    WindowStateChanged?.Invoke(this, this.WindowState);
                };
            }
        };
    }

    private void ToggleWindowState()
    {
        WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void TestView_Loaded(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
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

    public event EventHandler<WindowState>? WindowStateChanged;
    public event EventHandler? WindowLoaded;
}