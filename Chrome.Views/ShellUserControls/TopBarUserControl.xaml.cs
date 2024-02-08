using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chrome.Views.ShellUserControls;

public partial class TopBarUserControl : UserControl
{
    public TopBarUserControl()
    {
        InitializeComponent();
    }

    private void DragWindow(object sender, MouseButtonEventArgs e)
    {
        //DragMove();
    }

    private void BtnMinimize_Click(object sender, RoutedEventArgs e)
    {
        //WindowState = WindowState.Minimized;
    }

    private void BtnMaximize_Click(object sender, RoutedEventArgs e)
    {
        //WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void BtnClose_Click(object sender, RoutedEventArgs e)
    {
        //Close();
        //Application.Current.Shutdown();
    }
}