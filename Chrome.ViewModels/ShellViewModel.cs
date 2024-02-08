using System.Windows;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Contracts;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels;

public class ShellViewModel : IShellViewModel
{
    private readonly IShellView _view;

    public bool CanClose { get; set; } = true;
    public ResizeMode ResizeMode { get; set; } = ResizeMode.CanResize;
    public IShellView GetView() => this._view;

    public ShellViewModel(IDependencyContainer container)
    {
        this._view = container.Resolve<IShellView>();

        this.RegisterCommands();

        this._view.SetDataContext(this);
    }

    public void OpenView()
    {
        this._view?.OpenMe();
    }

    public void CloseView()
    {
        if (CanClose)
        {
            this._view?.CloseMe();
        }
    }

    private void RegisterCommands()
    {

    }
}