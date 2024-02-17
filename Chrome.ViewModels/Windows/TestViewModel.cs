using System.Windows;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Commands.Common;
using Chrome.ViewModels.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Windows;

// ReSharper disable once ClassNeverInstantiated.Global
public class TestViewModel : BaseViewModel, ITestViewModel
{
    #region FIELDS

    #endregion

    #region PROPERTIES

    public string WindowTitle => "I'm a test window ...";
    public bool CanClose => true;
    public ResizeMode ResizeMode => ResizeMode.CanMinimize;
    public WindowState CurrentWindowState => WindowState.Normal;

    #endregion

    #region C-TOR

    public TestViewModel(IDependencyContainer container, ITestView view) 
        : base(container, view)
    {
        this.RegisterCommands();

        base.GetView().SetDataContext(this);
    }

    #endregion

    #region METHODS

    protected override void DisposeViewModel()
    {
        
    }

    #endregion

    #region HELPERS

    private void RegisterCommands()
    {
        base.MinimizeCommand = new MinimizeWindowCommand(this);
        base.MaximizeCommand = new MaximizeWindowCommand(this);
        base.CloseCommand = new CloseWindowCommand(this);
        base.DragCommand = new DragWindowCommand(this);
    }

    #endregion
}