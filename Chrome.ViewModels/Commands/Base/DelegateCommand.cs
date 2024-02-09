namespace Chrome.ViewModels.Commands.Base;

public abstract class DelegateCommand
{
    public abstract void Execute(object parameter);

    public virtual bool CanExecute(object parameter)
    {
        return true;
    }

    public virtual void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler? CanExecuteChanged;
}