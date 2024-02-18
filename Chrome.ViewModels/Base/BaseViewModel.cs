using System.Windows.Input;
using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;

namespace Chrome.ViewModels.Base;

public abstract class BaseViewModel(IDependencyContainer container, IView view) : ViewModel
{
    #region FIELDS

    protected readonly IDependencyContainer Container = container;

    #endregion

    #region PROPERTIES

    public IView GetView() => view;

    #endregion

    #region COMMANDS

    public ICommand? MinimizeCommand { get; protected set; }
    public ICommand? MaximizeCommand { get; protected set; }
    public ICommand? CloseCommand { get; protected set; }
    public ICommand? DragCommand { get; protected set; }

    #endregion

    #region METHODS

    public void MaximizeView()
    {
        view.MaximizeView();
    }

    public void MinimizeView()
    {
        view.MinimizeView();
    }

    public void CloseView()
    {
        view.CloseMe();
    }

    public void DragWindow()
    {
        view.DragMe();
    }

    #endregion
}