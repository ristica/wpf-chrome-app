namespace Chrome.ViewModels.Commands.Base;

public abstract class DelegateCommand
    (Action<object> action, Func<object, bool>? canExecute = null)
{
    public abstract void Execute(object parameter);
    public abstract bool CanExecute(object parameter);

    public virtual void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler? CanExecuteChanged;
}