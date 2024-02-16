using System.Windows;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Commands.Common;
using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Dependencies.Contracts;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Windows;

public class TestViewModel : ViewModel, ITestViewModel
{
    private readonly ITestView _view;

    public ITestView GetView() => _view;

    #region COMMANDS

    public ICommand? MinimizeCommand { get; private set; }
    public ICommand? MaximizeCommand { get; private set; }
    public ICommand? CloseCommand { get; private set; }

    #endregion

    #region HELPERS

    private void RegisterCommands()
    {
        MinimizeCommand = new MinimizeWindowCommand(this);
        MaximizeCommand = new MaximizeWindowCommand(this);
        CloseCommand = new CloseWindowCommand(this);
    }

    #endregion

    public TestViewModel(IDependencyContainer container)
    {
        this._view = container.Resolve<ITestView>();

        this.RegisterCommands();

        this._view.SetDataContext(this);
    }

    protected override void DisposeViewModel()
    {
    }

    public string WindowTitle => "I'm a test window ...";

    public bool CanClose => true;
    public ResizeMode ResizeMode => ResizeMode.CanMinimize;
    public WindowState CurrentWindowState => WindowState.Normal;
    public void MaximizeView()
    {
        this._view.MaximizeView();
    }

    public void MinimizeView()
    {
       this._view.MinimizeView();
    }

    public void CloseView()
    {
        this._view.CloseMe();
    }
}