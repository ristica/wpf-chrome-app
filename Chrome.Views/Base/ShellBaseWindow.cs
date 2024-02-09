using System.Windows;

namespace Chrome.Views.Base
{
    public abstract class ShellBaseWindow : Window
    {
        protected ShellBaseWindow()
        {
            this.Loaded += ShellBaseWindowLoaded;
        }

        protected virtual void ShellBaseWindowLoaded(object sender, RoutedEventArgs e)
        {

        }

        protected void ToggleWindowState()
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
    }
}
