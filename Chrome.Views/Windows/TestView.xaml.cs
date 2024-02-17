using System.Windows;
using Chrome.Views.Base;
using Chrome.Views.Contracts;

namespace Chrome.Views.Windows;

public partial class TestView : BaseView, ITestView
{
    #region FIELDS

    public event EventHandler<WindowState>? WindowStateChanged;
    public event EventHandler? WindowLoaded;

    #endregion

    #region PROPERTIES

    public WindowState CurrentWindowState => WindowState;

    #endregion

    #region COMMANDS

    #endregion

    #region C-TOR

    public TestView()
    {
        InitializeComponent();
    }

    #endregion

    #region METHODS

    #endregion

    #region HELPERS

    #endregion
}