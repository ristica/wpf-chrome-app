using System.Windows.Input;
using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;

namespace Chrome.ViewModels.Base;

public abstract class BaseViewModel : ViewModel
{
    #region FIELDS

    protected readonly IDependencyContainer Container;
    private readonly IView _view;

    #endregion

    #region PROPERTIES

    public IView GetView()
    {
        return _view;
    }

    #endregion

    #region COMMANDS

    public ICommand? MinimizeCommand { get; protected set; }
    public ICommand? MaximizeCommand { get; protected set; }
    public ICommand? CloseCommand { get; protected set; }
    public ICommand? DragCommand { get; protected set; }

    #endregion

    #region C-TOR

    protected BaseViewModel(IDependencyContainer container, IView view)
    {
        Container = container;
        _view = view;
    }

    #endregion

    #region METHODS

    public void MaximizeView()
    {
        _view.MaximizeView();
    }

    public void MinimizeView()
    {
        _view.MinimizeView();
    }

    public void CloseView()
    {
        _view.CloseMe();
    }

    public void DragWindow()
    {
        _view.DragMe();
    }

    #endregion
}