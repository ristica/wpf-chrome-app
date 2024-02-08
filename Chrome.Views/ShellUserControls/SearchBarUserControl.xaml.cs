using System.Windows.Controls;
using System.Windows.Input;

namespace Chrome.Views.ShellUserControls;

public partial class SearchBarUserControl : UserControl
{
    public SearchBarUserControl()
    {
        InitializeComponent();
    }

    private void ToggleSideBar(object sender, MouseButtonEventArgs e)
    {
        //if (sender is not Border border) return;
        //switch (border.Name)
        //{
        //    case "SideBarHandle":
        //        BorderSideBar.Visibility = Visibility.Visible;
        //        SideBarHandle.Visibility = Visibility.Collapsed;
        //        break;
        //    case "BtnCloseSideBar":
        //        BorderSideBar.Visibility = Visibility.Collapsed;
        //        SideBarHandle.Visibility = Visibility.Visible;
        //        break;
        //}
    }
}