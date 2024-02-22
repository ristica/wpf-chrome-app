namespace Chrome.Common.Contracts;

public interface IUserControl
{
    IUserControlParentViewModel? ViewModel { get; }
    void SetDataContext<T>(T? viewModel) where T : IUserControlParentViewModel;
}